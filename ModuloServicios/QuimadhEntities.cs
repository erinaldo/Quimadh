using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloServicios
{
    public partial class QuimadhEntities : Entidades.QuimadhEntities
    {

        public QuimadhEntities() : base()
        { 
            
        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException exDB)
            {
                string mensajeFinal = "";

                foreach (var eve in exDB.EntityValidationErrors)
                {
                    mensajeFinal = String.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State) + Environment.NewLine;
                    foreach (var ve in eve.ValidationErrors)
                    {
                        mensajeFinal += String.Format("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage) + Environment.NewLine;
                    }
                }
                throw new Exception(mensajeFinal);
            }
        }

    }

}
