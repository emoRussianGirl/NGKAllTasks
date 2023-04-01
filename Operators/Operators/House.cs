using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGKOperators
{
    /// <summary>
    /// Здание.
    /// </summary>
    public class House
    {
        private int _floorsCount;

        private int _squareFootage;

        private decimal _decorationCost;


        /// <summary>
        /// Количество этажей.
        /// </summary>
        public int FloorsCount
        {
            get
            {
                return _floorsCount;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Количество этажей здания не может быть меньше 1.");
                }

                _floorsCount = value;
            }
        }

        /// <summary>
        /// Площадь в м^2.
        /// </summary>
        public int SquareFootage
        {
            get
            {
                return _squareFootage;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Площадь здания в квадратных метрах не может быть меньше или равна нулю.");
                }

                _squareFootage = value;
            }
        }

        /// <summary>
        /// Стоимость отделки.
        /// </summary>
        public decimal DecorationCost
        {
            get
            {
                return _decorationCost;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Стоимость отделки здания не может быть меньше нуля.");
                }

                _decorationCost = value;
            }
        }

        public House()
        {
            FloorsCount = 1;
            SquareFootage = 1;
            DecorationCost= 0;
        }

        public House(
            int floorsCount, 
            int squareFootage, 
            decimal decorationCost)
        {
            FloorsCount= floorsCount;
            SquareFootage= squareFootage;
            DecorationCost= decorationCost;
        }

        public override string ToString()
        {
            return $"Кол-во этажей здания: {FloorsCount}\n" +
                $"Площадь: {SquareFootage}м2\n" +
                $"Стоимость отделки: {DecorationCost}р\n";
        }

        public override bool Equals(object? obj)
        {
            House otherHouse = (obj as House)!;

            return otherHouse is not null && 
                (this.FloorsCount == otherHouse.FloorsCount &&
                 this.SquareFootage == otherHouse.SquareFootage &&
                 this.DecorationCost == otherHouse.DecorationCost);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static House operator +(House house1, House house2)
        {
            return new House(
                house1.FloorsCount + house2.FloorsCount,
                house1.SquareFootage + house2.SquareFootage,
                house1.DecorationCost + house2.DecorationCost);
        }

        public static House operator -(House house1, House house2)
        {
            int resultFloors = house1.FloorsCount - house2.FloorsCount;
            int resultSquare = house1.SquareFootage- house2.SquareFootage;
            decimal resultDecorationCost = house1.DecorationCost - house2.DecorationCost;

            return new House(
                resultFloors >= 1 ? resultFloors : 1,
                resultSquare > 0 ? resultSquare : 1,
                resultDecorationCost >= 0 ? resultDecorationCost : 0);
        }

        public static House operator *(House house, int num)
        {
            if (num <= 0)
            {
                throw new OperationCanceledException("Свойства дома не могут быть меньше нуля или некоторые равными нулю");
            }

            return new House(
                house.FloorsCount * num,
                house.SquareFootage * num,
                house.DecorationCost * num);
        }

        public static House operator /(House house, int num)
        {
            if (num <= 0)
            {
                throw new OperationCanceledException("Деление на ноль невозможно. Свойства дома не могу быть отрицательными.");
            }

            return new House(
                house.FloorsCount / num,
                house.SquareFootage / num,
                house.DecorationCost / num);
        }

        public static bool operator >(House house1, House house2)
        {
            return house1.SquareFootage > house2.SquareFootage;
        }

        public static bool operator <(House house1, House house2)
        {
            return house1.SquareFootage < house2.SquareFootage;
        }

        public static bool operator >=(House house1, House house2)
        {
            return house1.SquareFootage >= house2.SquareFootage;
        }

        public static bool operator <=(House house1, House house2)
        {
            return house1.SquareFootage <= house2.SquareFootage;
        }

        public static bool operator ==(House house1, House house2)
        {
            if (house1 is null || house2 is null)
            {
                return false;
            }

            return house1.SquareFootage == house2.SquareFootage;
        }

        public static bool operator !=(House house1, House house2)
        {
            if (house1 is null || house2 is null)
            {
                return false;
            }

            return house1?.SquareFootage != house2?.SquareFootage;
        }
    }
}
