using System;
using System.Collections.Generic;
using System.Text;

namespace gpacalc
{
    class Calculator
    {
        private int _totalCreditUnit;
        private int _gradePoint;
        private int _creditUnit;
        private int _score;
        private int _total;
        private int _counter = 0;


        public void CalculateGP()
        {
            this.Intro();

            do
            {
                Console.Write("Enter score for course #{0} (press 0 to exit): ", _counter += 1);
                _score = int.Parse(Console.ReadLine());

                if (_score == 0)
                {
                    break;
                }
                else
                {
                    Console.Write("Enter unit of the course: ");
                    _creditUnit = int.Parse(Console.ReadLine());

                    _gradePoint = this.ConvertScoreToGradePoint(this._score);

                    _total = _total + (_gradePoint * _creditUnit);
                    _totalCreditUnit = _totalCreditUnit + _creditUnit;

                }
            } while (_score != 0);

            decimal GPA = _total / _totalCreditUnit;
            Console.WriteLine("Your GPA this semester is: {0}", GPA.ToString("F"));
        }

        public int ConvertScoreToGradePoint(int Score)
        {
            if (Score >= 70 && Score <= 100)
            {
                return _gradePoint = 5;
            }
            else if (Score >= 60 && Score <= 69)
            {
                return _gradePoint = 4;
            }
            else if (Score >= 50 && Score <= 59)
            {
                return _gradePoint = 3;
            }
            else if (Score >= 45 && Score <= 49)
            {
                return _gradePoint = 2;
            }
            else if (Score >= 40 && Score <= 44)
            {
                return _gradePoint = 1;
            }
            else if (Score <= 39)
            {
                return _gradePoint = 0;
            }
            else
            {
                return _gradePoint;
            }
        }

        public void Intro()
        {
            Console.Write("\n********************************************\n");

            Console.WriteLine(
                "70 - 100 A \n" +
                "60 - 69 B \n" +
                "50 - 59 C \n" +
                "45 - 49 D \n" +
                "40 - 44 E \n" +
                "39 and below \n"
            );
        }
    }
}
