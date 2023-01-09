using System;
using System.Collections.Generic;
using System.Text;

namespace Villamigos.Dominio.Comun
{
    public abstract class Entidad<TId> : IEquatable<Entidad<TId>>
    {
        public TId Id { get; protected set; }
        protected Entidad(TId id)
        {
            if (object.Equals(id, default(TId)))
            {
                throw new ArgumentException(
                    "No se puede asignar el valor por defecto al ID", "id");
            }
            this.Id = id;
        }

        public override bool Equals(object obj)
        {
            var entity = obj as Entidad<TId>;
            if (entity != null)
            {
                return this.Equals(entity);
            }
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public bool Equals(Entidad<TId> other)
        {
            if (other == null)
            {
                return false;
            }
            return Id.Equals(other.Id);
        }
    }
}





