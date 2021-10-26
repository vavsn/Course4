using System;
using System.Collections.Generic;
using System.Text;

namespace Building
{
    class Building
    {
        /// <summary>
        /// эргономичная высота этажа
        /// </summary>
        private static double _ergonomicheight = 2.5;
        /// <summary>
        /// номер здания
        /// </summary>
        private int _num;

        /// <summary>
        /// последний использованный номер здания
        /// </summary>
        private static int _lastnum;

        /// <summary>
        /// высота здания 
        /// </summary>
        private double _height;

        /// <summary>
        /// количество этажей в здании
        /// </summary>
        private int _countfloor;

        /// <summary>
        /// высота этажа
        /// </summary>
        private double _heightfloor
        { 
            get {
                double _heightfloor = -1;
                if ((_countfloor > 0) & (_height > 0))
                {
                    _heightfloor = _height / _countfloor;
                }
                return _heightfloor;
            }
        }

        /// <summary>
        /// количество квартир в здании
        /// </summary>
        private int _countflat;

        /// <summary>
        /// количество подъездов в здании
        /// </summary>
        private int _countentrance;

        public void SetNum(int num)
        {
            if (num < 1)
            {
                throw new Exception("Не корректно указан номер здания");
            }
            if (num < _lastnum)
            {
                throw new Exception($"Номер здания должен быть больше {_lastnum}");
            }
            _lastnum = num;
            _num = num;
        }
        public int AutoSetNum()
        {
            _lastnum++;
            _num = _lastnum;
            return _num;
        }
        public int GetNum()
        {
            return _num;
        }

        public void SetHeight(double height)
        {
            _height = (height > 0) ?
                height :
                throw new Exception("Не корректно указана высота здания");
        }

        public double GetHeight()
        {
            return _height;
        }

        public void SetCountFloor(int count)
        {
            _countfloor = count > 0 ?
                count :
                throw new Exception("Не корректно указано количество этажей в здании");
        }

        public int GetCountFloor()
        {
            return _countfloor;
        }

        public void SetCountFlat(int count)
        {
            _countflat = count > 0 ?
                count :
                throw new Exception("Не корректно указано количество квартир в здании");
        }

        public int GetCountFlat()
        {
            return _countflat;
        }

        public void SetCountEntrance(int count)
        {
            _countentrance = count > 0 ?
                count :
                throw new Exception("Не корректно указано количество подъездов в здании");
        }

        public int GetCountEntrance()
        {
            return _countentrance;
        }

        public int GetCountFlatOnFloor()
        {
            return _countflat / _countfloor;
        }

        public int GetCountFlatOnEntrance()
        {
            return _countflat / _countentrance;
        }
        public double GetHeightFloor()
        {
            return _heightfloor;
        }
        public bool GetErgonomic()
        {
            return _heightfloor > _ergonomicheight;
        }
    }
}
