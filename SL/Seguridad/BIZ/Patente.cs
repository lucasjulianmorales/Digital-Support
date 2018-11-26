using System;

namespace Entity
{
    public class Patente : FamiliaElement
    {

        public Patente()
        {

        }

        public override void Add(FamiliaElement d)
        {
            throw new Exception("No se puede agregar una patente");
        }

        public override void Remove(FamiliaElement d)
        {
            throw new Exception("No se puede quitar una patente");
        }

        public override int ChildrenCount
        {
            get
            {
                return 0;
            }
        }
    }
}
