using Entidades;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Vistas.Analisis
{
    public static class Resultados
    {

        public static void ArmarDocumento(Document document, CabeceraRutina rutina, int muestras)
        {
            Paragraph paragraph = document.LastSection.AddParagraph("");

            DefineStyles(document);
            Encabezado(document, rutina, muestras);
            ResultadosInt(document, rutina);
            Pie(document, rutina, muestras);
        }

        private static void DefineStyles(Document document)
        {
            // Get the predefined style Normal.
            Style style = document.Styles["Normal"];
            // Because all styles are derived from Normal, the next line changes the 
            // font of the whole document. Or, more exactly, it changes the font of
            // all styles and paragraphs that do not redefine the font.
            style.Font.Name = "Times New Roman";

            // Heading1 to Heading9 are predefined styles with an outline level. An outline level
            // other than OutlineLevel.BodyText automatically creates the outline (or bookmarks) 
            // in PDF.

            style = document.Styles["Heading1"];
            style.Font.Name = "Tahoma";
            style.Font.Size = 14;
            style.Font.Bold = true;
            style.Font.Color = Colors.DarkBlue;
            style.ParagraphFormat.PageBreakBefore = true;

            style = document.Styles["Heading2"];
            style.Font.Size = 12;
            style.Font.Bold = true;
            style.ParagraphFormat.PageBreakBefore = false;

            style = document.Styles["Heading3"];
            style.Font.Size = 10;
            style.Font.Bold = true;
            style.Font.Italic = true;

            // Create a new style called TextBox based on style Normal
            style = document.Styles.AddStyle("TextBox", "Normal");
            style.ParagraphFormat.Alignment = ParagraphAlignment.Justify;
            style.ParagraphFormat.Borders.Width = 2.5;
            style.ParagraphFormat.Borders.Distance = "3pt";
            //TODO: Colors
            style.ParagraphFormat.Shading.Color = Colors.SkyBlue;

            // Create a new style called TOC based on style Normal
            style = document.Styles.AddStyle("TOC", "Normal");
            style.ParagraphFormat.AddTabStop("16cm", TabAlignment.Right, TabLeader.Dots);
            style.ParagraphFormat.Font.Color = Colors.Blue;

            style = document.Styles.AddStyle("Negrita", "Normal");
            style.ParagraphFormat.Font.Bold = true;

            style = document.Styles.AddStyle("NegritaSubrayado", "Normal");
            style.ParagraphFormat.Font.Bold = true;
            style.ParagraphFormat.Font.Underline = Underline.Single;

            style = document.Styles.AddStyle("TituloAnalisis", "Normal");
            style.ParagraphFormat.Font.Bold = true;
            style.ParagraphFormat.Font.Color = Colors.Blue;
            style.ParagraphFormat.Font.Underline = Underline.Single;
            style.Font.Size = 12;
            style.ParagraphFormat.PageBreakBefore = false;

        }

        public static void Encabezado(Document document, CabeceraRutina rutina, int muestras)
        {
            Cliente cliente = Global.Servicio.buscarUnCliente(rutina.idPlanta);
            Paragraph paragraph;
            document.LastSection.AddParagraph("");

            Table table = new Table();
            table.Borders.Width = 0;

            Column column = table.AddColumn(Unit.FromCentimeter(13));
            column.Format.Alignment = ParagraphAlignment.Center;

            if(muestras > 8)
                table.AddColumn(Unit.FromCentimeter(14));
            else
                table.AddColumn(Unit.FromCentimeter(6));

            String textoEncabezado = Environment.NewLine + Environment.NewLine + "ANÁLISIS DE AGUA NÚMERO:" ;
            String datosCliente = "";

            if (cliente != null)
            {
                datosCliente += Environment.NewLine + Environment.NewLine + "Cliente:" + "\t" + cliente.razonSocial + Environment.NewLine + "\t\t" + cliente.direccion + Environment.NewLine + "\t\t";
                if(cliente.Localidad != null)
                    datosCliente += cliente.Localidad.nombre + Environment.NewLine;
            }

            Row row = table.AddRow();
            //row.Shading.Color = Colors.PaleGoldenrod;
            Cell cell = row.Cells[0];
            paragraph = cell.AddParagraph(textoEncabezado);
            paragraph.Format.Alignment = ParagraphAlignment.Left;
            paragraph.Style = "TituloAnalisis";

            paragraph.AddFormattedText(rutina.id.ToString(), "Negrita");

            paragraph = cell.AddParagraph(datosCliente);
            paragraph.Format.Alignment = ParagraphAlignment.Left;
            paragraph.Style = "Negrita";

            cell = row.Cells[1];
            paragraph = cell.AddParagraph();
            paragraph.Format.Alignment = ParagraphAlignment.Right;         

            if(muestras > 8)
                paragraph.AddImage(@"C:\Quimadh\quima2.png");
            else
                paragraph.AddImage(@"C:\Quimadh\quima.png");

            row = table.AddRow();
            cell = row.Cells[0];
            paragraph = cell.AddParagraph("");
            paragraph.Format.Alignment = ParagraphAlignment.Left;
            paragraph.AddFormattedText("Planta:", "NegritaSubrayado");
            paragraph.AddFormattedText("        " + rutina.Planta.nombre, "Negrita");
            paragraph.Format.Alignment = ParagraphAlignment.Left;
            cell = row.Cells[1];
            paragraph = cell.AddParagraph("");
            paragraph.AddFormattedText("Fecha Muestreo: ", "NegritaSubrayado");
            paragraph.Format.Alignment = ParagraphAlignment.Right;            
            paragraph.AddFormattedText(rutina.fechaMuestreo.Value.ToShortDateString(), "Negrita");

            row = table.AddRow();
            cell = row.Cells[0];
            cell.AddParagraph("");
            cell = row.Cells[1];
            cell.AddParagraph("");

            table.SetEdge(0, 0, 2, 3, Edge.Bottom, BorderStyle.Single, 1.5, Colors.Black);

            document.LastSection.Add(table);

            List<Muestra> m = (from d in rutina.DatosRutina
                                      select d.Muestra).Distinct().ToList();

            table = new Table();
            table.Borders.Width = 0;

            if (muestras > 8) //13+14
            {
                table.AddColumn(Unit.FromCentimeter(4.85));
                table.AddColumn(Unit.FromCentimeter(4.85));
                table.AddColumn(Unit.FromCentimeter(4.85));
                table.AddColumn(Unit.FromCentimeter(4.85));
                table.AddColumn(Unit.FromCentimeter(4.85));
                table.AddColumn(Unit.FromCentimeter(4.85));
            }
            else //13 + 6
            {
                table.AddColumn(Unit.FromCentimeter(4.75));
                table.AddColumn(Unit.FromCentimeter(4.75));
                table.AddColumn(Unit.FromCentimeter(4.75));
                table.AddColumn(Unit.FromCentimeter(4.75));
            }

            //Descripciones de las muestras
            for (int i = 0; i < m.Count; i++)
            {
                if (i % 3 == 0 && muestras < 9) //Hoja vertical nueva fila
                {
                    row = table.AddRow();
                }
                if (i % 5 == 0 && muestras > 8) //Hoja horizontal nueva fila
                {
                    row = table.AddRow();
                }
                if (muestras < 9)
                {
                    cell = row.Cells[i % 3];
                    cell.AddParagraph(m[i].Codigo + ":" + m[i].Descripcion);
                }
                if (muestras > 8)
                {
                    cell = row.Cells[i % 5];
                    cell.AddParagraph(m[i].Codigo + ":" + m[i].Descripcion);
                }                

            }

            document.LastSection.Add(table);

        }


        public static void ResultadosInt(Document document, CabeceraRutina rutina)
        {
            int grupo = 1;
            Paragraph paragraph;
            document.LastSection.AddParagraph("");

            Table table = new Table();
            table.Borders.Width = 0;

            Column column = table.AddColumn(Unit.FromCentimeter(5.5));
            column.Format.Alignment = ParagraphAlignment.Left;

            table.AddColumn(Unit.FromCentimeter(2.2)).Format.Alignment = ParagraphAlignment.Center;
            //Agregar tantas columnas como determinantes haya, hasta 7 por hoja. Restan 13 cms para dichas columnas.
            

            List<Determinante> determinantes = (from d in rutina.DatosRutina
                                                select d.Determinante).OrderBy(d => d.grupo).Distinct().ToList();
            List<Muestra> muestras = (from d in rutina.DatosRutina
                                      select d.Muestra).Distinct().ToList();

            foreach (Muestra m in muestras)
            {
                table.AddColumn(Unit.FromCentimeter(1.6));
            }

            int i = 2;
            Row row = table.AddRow();
            row.Shading.Color = Colors.AliceBlue;
            Cell cell = row.Cells[0];
            cell.AddParagraph("PARÁMETRO").Format.Alignment = ParagraphAlignment.Center;

            cell = row.Cells[1];
            cell.AddParagraph("UNIDAD").Format.Alignment = ParagraphAlignment.Center;

            foreach (Muestra m in muestras)
            {
                cell = row.Cells[i];
                cell.AddParagraph(m.Codigo).Format.Alignment = ParagraphAlignment.Center;
                i++;
            }

            i = 0;
            row = table.AddRow();
            cell = row.Cells[0];
            paragraph = cell.AddParagraph("");
            paragraph.Format.Alignment = ParagraphAlignment.Left;
            paragraph.AddFormattedText("ANÁLISIS FÍSICO - QUÍMICO", "NegritaSubrayado").Size = 8;

            Color color = Colors.White;
            bool muestraTitulo = false;
            for(int k=0; k < determinantes.Count; k++)
            {
                Determinante d = determinantes.ElementAt(k);

                if (d.grupo == 5 && !muestraTitulo)
                {
                    muestraTitulo = true;
                    row = table.AddRow();
                    cell = row.Cells[0];
                    paragraph = cell.AddParagraph("");
                    //paragraph.Format.Alignment = ParagraphAlignment.Center;
                    paragraph.AddFormattedText("ANÁLISIS DE CARGA ORGÁNICA", "NegritaSubrayado").Size = 8;
                }

                row = table.AddRow();

                cell = row.Cells[0];
                cell.AddParagraph(d.nombre).Format.Alignment = ParagraphAlignment.Left;

                cell = row.Cells[1];
                cell.AddParagraph(d.unidad).Format.Alignment = ParagraphAlignment.Center;

                for (i = 2; i < muestras.Count + 2; i++)
                {
                    Muestra m = muestras[i - 2];
                    string valor = rutina.DatosRutina.Where(dr => dr.idMuestra == m.Id && dr.idDeterminante == d.id && dr.idCabeceraRutina == rutina.id).First().valor;

                    cell = row.Cells[i];
                    if (grupo != d.grupo)
                        if(color == Colors.LightGray)
                            color = Colors.White;
                        else
                            color = Colors.LightGray;

                    cell.Shading.Color = color;
                    cell.AddParagraph(valor).Format.Alignment = ParagraphAlignment.Right;
                    grupo = (short)d.grupo;
                }               
                    
            }
                                

            //Caja en el encabezado.
            table.SetEdge(0, 0, table.Columns.Count, 1, Edge.Box, BorderStyle.Single, 1.5, Colors.Black);
            //Caja en la segunda columna.
            table.SetEdge(1, 0, 1, table.Rows.Count, Edge.Box, BorderStyle.Single, 1.5, Colors.Black);



            document.LastSection.Add(table);
        }

        public static void Pie(Document document, CabeceraRutina rutina, int muestras)
        {
            Paragraph paragraph;
            string firmaPersona = rutina.observaciones.Split(new string[] { "[f]" }, StringSplitOptions.None).Length > 1 ? rutina.observaciones.Split(new string[] { "[f]" }, StringSplitOptions.None)[1] : "";
            string observaciones = firmaPersona == "" ? rutina.observaciones : rutina.observaciones.Split(new string[] { "[f]" }, StringSplitOptions.None)[0];
            Table table = new Table();
            table.Borders.Width = 0;

            Column column;
                
            if(muestras > 8)                
                column = table.AddColumn(Unit.FromCentimeter(27));
            else
                column = table.AddColumn(Unit.FromCentimeter(19));

            column.Format.Alignment = ParagraphAlignment.Center;

            Row row = table.AddRow();
            //row.Shading.Color = Colors.PaleGoldenrod;
            Cell cell = row.Cells[0];            
            paragraph = cell.AddParagraph("");
            paragraph.AddFormattedText("Observaciones:", "NegritaSubrayado");
            paragraph.Format.Alignment = ParagraphAlignment.Left;
            row = table.AddRow();
            cell = row.Cells[0];

            if (muestras > 8)
                cell.AddParagraph(observaciones).Format.Alignment = ParagraphAlignment.Left;
            else
            {
                cell.AddParagraph(observaciones + Environment.NewLine + Environment.NewLine).Format.Alignment = ParagraphAlignment.Left;
                paragraph = cell.AddParagraph("" + Environment.NewLine + Environment.NewLine);
            }


            if (firmaPersona != "")
            {
                paragraph = cell.AddParagraph("");
                paragraph.AddFormattedText("\t\t\t\t\t" + firmaPersona.Replace("\n", "\n\t\t\t\t\t"), "Negrita");
                paragraph.Format.Alignment = ParagraphAlignment.Center;            
            }

            row = table.AddRow();
            cell = row.Cells[0];
            cell.AddParagraph("Datos de la empresa").Format.Alignment = ParagraphAlignment.Center;
            row = table.AddRow();
            cell = row.Cells[0];
            cell.AddParagraph("Web: www.quimadh.com.ar | e-mail: oficinatecnica@quimadh.com.ar").Format.Alignment = ParagraphAlignment.Center;

            table.SetEdge(0, 0, 1, 2, Edge.Top, BorderStyle.Single, 3, Colors.Black);

            table.SetEdge(0, 2, 1, 2, Edge.Top, BorderStyle.Single, 3, Colors.Red);

            document.LastSection.Footers.Primary.Add(table);




        }
    }
}
