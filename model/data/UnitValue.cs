using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos
{
    public class UnitValue<T>
    {
        public T Value { get; set; }

        public Unit Unit { get; }

        public static UnitValue<T> Of(T value, Unit unit)
        {
            return new UnitValue<T>(value, unit);
        }

        public UnitValue(T value, Unit unit)
        {
            Value = value;
            Unit = unit;
        }

        public T Get()
        {
            return Value;
        }

        public void Set(T value)
        {
            Value = value;
        }

        public Unit GetUnit()
        {
            return Unit;
        }
    }
}
