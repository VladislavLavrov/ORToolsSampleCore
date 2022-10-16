using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORToolsSampleCore.Models
{
    public class DataInputModel
    {      
        /*
         * Целевая функция:
            2X1 - 3X2 + 4X3 -> min

            Прямые ограничения на X:
            0 <= X1  <=  10
            0 <= X2  <=  100
            0 <= X3  <=  20

            Ограничения-неравенства:
            X1 + 2X2 + 3X3 <= 900
            2X1 + 10X2 - 5X3 <= 950

            Для нахождения максимального значения необходимо поменять 
            знак коэффициентов целевой функции.         
         * */

        #region --- Переменные

        private double _X1;    // закрытая переменная класса 
        /// <summary>
        /// Величина X1
        /// </summary> 
        public double X1
        {
            get { return _X1; }
            set { _X1 = value; }
        }

        private double _X2;    // закрытая переменная класса 
        /// <summary>
        /// Величина X2
        /// </summary> 
        public double X2
        {
            get { return _X2; }
            set { _X2 = value; }
        }

        private double _X3;    // закрытая переменная класса 
        /// <summary>
        /// Величина X3
        /// </summary> 
        public double X3
        {
            get { return _X3; }
            set { _X3 = value; }
        }

        #endregion --- Переменные

        #region --- Ограничения минимум/максимум на переменные

        private double _X1_min;    // закрытая переменная класса 
        /// <summary>
        /// Минимальная величина X1
        /// </summary> 
        public double X1_min
        {
            get { return _X1_min; }
            set { _X1_min = value; }
        }

        private double _X1_max;    // закрытая переменная класса 
        /// <summary>
        /// Максимальная величина X1
        /// </summary> 
        public double X1_max
        {
            get { return _X1_max; }
            set { _X1_max = value; }
        }

        private double _X2_min;    // закрытая переменная класса 
        /// <summary>
        /// Минимальная величина X2
        /// </summary> 
        public double X2_min
        {
            get { return _X2_min; }
            set { _X2_min = value; }
        }

        private double _X2_max;    // закрытая переменная класса 
        /// <summary>
        /// Максимальная величина X2
        /// </summary> 
        public double X2_max
        {
            get { return _X2_max; }
            set { _X2_max = value; }
        }

        private double _X3_min;    // закрытая переменная класса 
        /// <summary>
        /// Минимальная величина X3
        /// </summary> 
        public double X3_min
        {
            get { return _X3_min; }
            set { _X3_min = value; }
        }

        private double _X3_max;    // закрытая переменная класса 
        /// <summary>
        /// Максимальная величина X3
        /// </summary> 
        public double X3_max
        {
            get { return _X3_max; }
            set { _X3_max = value; }
        }

        #endregion --- Ограничения минимум/максимум на переменные

        #region --- Коэффициенты целевой функции

        private double _Koeff_Z_1;    // закрытая переменная класса 
        /// <summary>
        /// Величина коэффициента целевой функции при X1
        /// </summary> 
        public double Koeff_Z_1
        {
            get { return _Koeff_Z_1; }
            set { _Koeff_Z_1 = value; }
        }

        private double _Koeff_Z_2;    // закрытая переменная класса 
        /// <summary>
        /// Величина коэффициента целевой функции при X2
        /// </summary> 
        public double Koeff_Z_2
        {
            get { return _Koeff_Z_2; }
            set { _Koeff_Z_2 = value; }
        }

        private double _Koeff_Z_3;    // закрытая переменная класса 
        /// <summary>
        /// Величина коэффициента целевой функции при X3
        /// </summary> 
        public double Koeff_Z_3
        {
            get { return _Koeff_Z_3; }
            set { _Koeff_Z_3 = value; }
        }

        #endregion --- Коэффициенты целевой функции

        #region --- Коэффициенты в уравнениях ограничений

        private double _ConstraintKoeff_1_X1;    // закрытая переменная класса 
        /// <summary>
        /// Величина коэффициента в 1-м уравнении ограничений при X1
        /// </summary> 
        public double ConstraintKoeff_1_X1
        {
            get { return _ConstraintKoeff_1_X1; }
            set { _ConstraintKoeff_1_X1 = value; }
        }

        private double _ConstraintKoeff_1_X2;    // закрытая переменная класса 
        /// <summary>
        /// Величина коэффициента в 1-м уравнении ограничений при X2
        /// </summary> 
        public double ConstraintKoeff_1_X2
        {
            get { return _ConstraintKoeff_1_X2; }
            set { _ConstraintKoeff_1_X2 = value; }
        }

        private double _ConstraintKoeff_1_X3;    // закрытая переменная класса 
        /// <summary>
        /// Величина коэффициента в 1-м уравнении ограничений при X3
        /// </summary> 
        public double ConstraintKoeff_1_X3
        {
            get { return _ConstraintKoeff_1_X3; }
            set { _ConstraintKoeff_1_X3 = value; }
        }


        private double _ConstraintKoeff_2_X1;    // закрытая переменная класса 
        /// <summary>
        /// Величина коэффициента во 2-м уравнении ограничений при X1
        /// </summary> 
        public double ConstraintKoeff_2_X1
        {
            get { return _ConstraintKoeff_2_X1; }
            set { _ConstraintKoeff_2_X1 = value; }
        }

        private double _ConstraintKoeff_2_X2;    // закрытая переменная класса 
        /// <summary>
        /// Величина коэффициента во 2-м уравнении ограничений при X2
        /// </summary> 
        public double ConstraintKoeff_2_X2
        {
            get { return _ConstraintKoeff_2_X2; }
            set { _ConstraintKoeff_2_X2 = value; }
        }

        private double _ConstraintKoeff_2_X3;    // закрытая переменная класса 
        /// <summary>
        /// Величина коэффициента во 2-м уравнении ограничений при X3
        /// </summary> 
        public double ConstraintKoeff_2_X3
        {
            get { return _ConstraintKoeff_2_X3; }
            set { _ConstraintKoeff_2_X3 = value; }
        }

        #endregion --- Коэффициенты в уравнениях ограничений

        #region --- Столбцы свободных членов в уравнениях ограничений типа неравенств

        private double _Constraint_1_Ub;    // закрытая переменная класса 
        /// <summary>
        /// Величина коэффициента свободного члена в 1-м уравнении ограничений (верхний предел)
        /// </summary> 
        public double Constraint_1_Ub
        {
            get { return _Constraint_1_Ub; }
            set { _Constraint_1_Ub = value; }
        }

        private double _Constraint_2_Ub;    // закрытая переменная класса 
        /// <summary>
        /// Величина коэффициента свободного члена во 2-м уравнении ограничений (верхний пределе)
        /// </summary> 
        public double Constraint_2_Ub
        {
            get { return _Constraint_2_Ub; }
            set { _Constraint_2_Ub = value; }
        }

        private double _Constraint_1_Lb;    // закрытая переменная класса 
        /// <summary>
        /// Величина коэффициента свободного члена в 1-м уравнении ограничений (нижний предел)
        /// </summary> 
        public double Constraint_1_Lb
        {
            get { return _Constraint_1_Lb; }
            set { _Constraint_1_Lb = value; }
        }

        private double _Constraint_2_Lb;    // закрытая переменная класса 
        /// <summary>
        /// Величина коэффициента свободного члена во 2-м уравнении ограничений (нижний пределе)
        /// </summary> 
        public double Constraint_2_Lb
        {
            get { return _Constraint_2_Lb; }
            set { _Constraint_2_Lb = value; }
        }

        #endregion --- Столбцы свободных членов в уравнениях ограничений типа неравенств
    }
}
