using System;

namespace RTN
{
    class CalculatorRTN
    {
        const double g = 9.8;

        private double freeHigh;

        private double length;

        private double high;

        private double wide;

        private double value;

        private double alfa;

        private int temp_out;

        private int typeOfBuild;

        private bool year;

        private double qUdel;

        private double qVent;

        private int temp_in;

        private double temp_midle;

        private double speedOfWind;

        private int countDays;

        private double coefInfiltration;

        private double qHot;

        private double midleHotEnergy;

        private decimal costOne;

        private decimal totalCoast;

        private double summEnergy = 0;


        public double Length { get => length; set => length = value; }
        public double High { get => high; set => high = value; }
        public double Wide { get => wide; set => wide = value; }
        public double Value { get => value; set => this.value = value; }
        public double Alfa { get => alfa; set => alfa = value; }
        public int Temp_out { get => temp_out; set => temp_out = value; }
        public int TypeOfBuild { get => typeOfBuild; set => typeOfBuild = value; }
        public bool Year { get => year; set => year = value; }
        public double QUdel { get => qUdel; set => qUdel = value; }
        public double QVent { get => qVent; set => qVent = value; }
        public int Temp_in { get => temp_in; set => temp_in = value; }
        public double SpeedOfWind { get => speedOfWind; set => speedOfWind = value; }
        public int CountDays { get => countDays; set => countDays = value; }
        public double FreeHigh { get => freeHigh; set => freeHigh = value; }
        public double CoefInfiltration { get => coefInfiltration; set => coefInfiltration = value; }
        public double MidleHotEnergy { get => midleHotEnergy; set => midleHotEnergy = value; }

        public double Temp_midle { get => temp_midle; set => temp_midle = value; }
        public double QHot { get => qHot; set => qHot = value; }
        public decimal CostOne { get => costOne; set => costOne = value; }
        public decimal TotalCoast { get => totalCoast; set => totalCoast = value; }
        public double SummEnergy { get => summEnergy; set => summEnergy = value; }

        public double CalculateVolume(double Length, double High, double Wide)
        {
            this.length = Length;
            this.high = High;
            this.wide = Wide;
            value = length * high * wide;
            return value;
        }

        public double GetAlfa(int Temp)
        {

            switch (Temp)
            {
                case -55:
                    alfa = 0.8;
                    break;
                case -50:
                    alfa = 0.82;
                    break;
                case -45:
                    alfa = 0.85;
                    break;
                case -40:
                    alfa = 0.9;
                    break;
                case -35:
                    alfa = 0.95;
                    break;
                case -30:
                    alfa = 1;
                    break;
                case -25:
                    alfa = 1.08;
                    break;
                case -20:
                    alfa = 1.17;
                    break;
                case -15:
                    alfa = 1.29;
                    break;
                case -10:
                    alfa = 1.45;
                    break;
                case -5:
                    alfa = 1.67;
                    break;
                case 0:
                    alfa = 2.05;
                    break;
            }

            return alfa;
        }

        public double GetqUdel(int index)
        {

            if (index == 1)
            {
                if (value < 5000)
                {
                    qUdel = 0.43;
                    qVent = 0.09;
                }
                else if (value >= 5000 && value < 10000)
                {
                    qUdel = 0.38;
                    qVent = 0.08;
                }
                else if (value >= 10000 && value < 15000)
                {
                    qUdel = 0.35;
                    qVent = 0.07;
                }
                else if (value >= 15000)
                {
                    qUdel = 0.32;
                    qVent = 0.18;
                }
            }
            else if (index == 2)
            {
                if (value < 5000)
                {
                    qUdel = 0.37;
                    qVent = 0.25;
                }
                else if (value >= 5000 && value < 10000)
                {
                    qUdel = 0.33;
                    qVent = 0.23;
                }
                else if (value >= 10000)
                {
                    qUdel = 0.3;
                    qVent = 0.2;
                }
            }
            else if (index == 3)
            {
                if (value < 5000)
                {
                    qUdel = 0.36;
                    qVent = 0.43;
                }
                else if (value >= 5000 && value < 10000)
                {
                    qUdel = 0.32;
                    qVent = 0.39;
                }
                else if (value >= 10000)
                {
                    qUdel = 0.3;
                    qVent = 0.38;
                }
            }
            else if (index == 4)
            {
                if (value < 10000)
                {
                    qUdel = 0.29;
                    qVent = 0.41;
                }
                else if (value >= 10000 && value < 15000)
                {
                    qUdel = 0.27;
                    qVent = 0.4;
                }
                else if (value >= 15000 && value < 20000)
                {
                    qUdel = 0.22;
                    qVent = 0.38;
                }
                else if (value >= 20000 && value < 30000)
                {
                    qUdel = 0.2;
                    qVent = 0.36;
                }
                else if (value >= 30000)
                {
                    qUdel = 0.18;
                    qVent = 0.31;
                }
            }
            else if (index == 5)
            {
                if (value < 5000)
                {
                    qUdel = 0.38;
                    qVent = 1;
                }
                else if (value >= 5000 && value < 10000)
                {
                    qUdel = 0.33;
                    qVent = 0.08;
                }
                else if (value >= 10000)
                {
                    qUdel = 0.31;
                    qVent = 0.27;
                }
            }
            else if (index == 6)
            {
                if (value < 5000)
                {
                    qUdel = 0.38;
                    qVent = 0.11;
                }
                else if (value >= 5000)
                {
                    qUdel = 0.34;
                    qVent = 0.1;
                }
            }
            else if (index == 7)
            {
                if (value < 5000)
                {
                    qUdel = 0.39;
                    qVent = 0.09;
                }
                else if (value >= 5000 && value < 10000)
                {
                    qUdel = 0.35;
                    qVent = 0.08;
                }
                else if (value >= 10000)
                {
                    qUdel = 0.33;
                    qVent = 0.07;
                }
            }
            else if (index == 8)
            {
                if (value < 5000)
                {
                    qUdel = 0.4;
                    qVent = 0.29;
                }
                else if (value >= 5000 && value < 10000)
                {
                    qUdel = 0.36;
                    qVent = 0.28;
                }
                else if (value >= 10000 && value < 15000)
                {
                    qUdel = 0.32;
                    qVent = 0.26;
                }
                else if (value >= 15000)
                {
                    qUdel = 0.3;
                    qVent = 0.25;
                }
            }
            else if (index == 9)
            {
                if (value < 5000)
                {
                    qUdel = 0.28;
                    qVent = 1;
                }
                else if (value >= 5000 && value < 10000)
                {
                    qUdel = 0.25;
                    qVent = 0.95;
                }
                else if (value >= 10000)
                {
                    qUdel = 0.23;
                    qVent = 0.9;
                }

            }
            else if (index == 10)
            {
                if (value < 5000)
                {
                    qUdel = 0.38;
                    qVent = 0.8;
                }
                else if (value >= 5000 && value < 10000)
                {
                    qUdel = 0.33;
                    qVent = 0.78;
                }
                else if (value >= 10000)
                {
                    qUdel = 0.31;
                    qVent = 0.75;
                }

            }
            else if (index == 11)
            {
                if (value < 5000)
                {
                    qUdel = 0.35;
                    qVent = 0.7;
                }
                else if (value >= 5000 && value < 10000)
                {
                    qUdel = 0.33;
                    qVent = 0.65;
                }
                else if (value >= 10000)
                {
                    qUdel = 0.3;
                    qVent = 0.6;
                }
            }
            else if (index == 12)
            {
                if (value < 5000)
                {
                    qUdel = 0.37;
                    qVent = 1;
                }
                else if (value >= 5000 && value < 10000)
                {
                    qUdel = 0.35;
                    qVent = 0.95;
                }
                else if (value >= 10000)
                {
                    qUdel = 0.33;
                    qVent = 0.9;
                }

            }
            else if (index == 13)
            {
                if (value < 2000)
                {
                    qUdel = 0.48;
                    qVent = 0.14;
                }
                else if (value >= 2000 && value < 5000)
                {
                    qUdel = 0.46;
                    qVent = 0.09;
                }
                else if (value >= 5000)
                {
                    qUdel = 0.45;
                    qVent = 0.09;
                }

            }
            else if (index == 14)
            {
                if (value < 2000)
                {
                    qUdel = 0.7;
                    qVent = 1;
                }
                else if (value >= 2000 && value < 3000)
                {
                    qUdel = 0.6;
                    qVent = 1;
                }
                else if (value >= 3000 && value < 5000)
                {
                    qUdel = 0.55;
                    qVent = 0.7;
                }
                else if (value >= 5000)
                {
                    qUdel = 0.5;
                    qVent = 0.65;
                }
            }
            else if (index == 15)
            {
                if (year)
                {
                    if (value < 100)
                    {
                        qUdel = 0.92;
                    }
                    else if (value >= 100 && value < 200)
                    {
                        qUdel = 0.82;
                    }
                    else if (value >= 200 && value < 300)
                    {
                        qUdel = 0.78;
                    }
                    else if (value >= 300 && value < 400)
                    {
                        qUdel = 0.74;
                    }
                    else if (value >= 400 && value < 500)
                    {
                        qUdel = 0.71;
                    }
                    else if (value >= 500 && value < 600)
                    {
                        qUdel = 0.69;
                    }
                    else if (value >= 600 && value < 700)
                    {
                        qUdel = 0.68;
                    }
                    else if (value >= 700 && value < 800)
                    {
                        qUdel = 0.67;
                    }
                    else if (value >= 800 && value < 900)
                    {
                        qUdel = 0.66;
                    }
                    else if (value >= 900 && value < 1000)
                    {
                        qUdel = 0.65;
                    }
                    else if (value >= 1000 && value < 1100)
                    {
                        qUdel = 0.62;
                    }
                    else if (value >= 1100 && value < 1200)
                    {
                        qUdel = 0.60;
                    }
                    else if (value >= 1200 && value < 1300)
                    {
                        qUdel = 0.59;
                    }
                    else if (value >= 1300 && value < 1400)
                    {
                        qUdel = 0.58;
                    }
                    else if (value >= 1400 && value < 1500)
                    {
                        qUdel = 0.57;
                    }
                    else if (value >= 1500 && value < 1600)
                    {
                        qUdel = 0.56;
                    }
                    else if (value >= 1600 && value < 1700)
                    {
                        qUdel = 0.55;
                    }
                    else if (value >= 1700 && value < 2000)
                    {
                        qUdel = 0.53;
                    }
                    else if (value >= 2000 && value < 2500)
                    {
                        qUdel = 0.52;
                    }
                    else if (value >= 2500 && value < 3000)
                    {
                        qUdel = 0.5;
                    }
                    else if (value >= 3000 && value < 3500)
                    {
                        qUdel = 0.48;
                    }
                    else if (value >= 3500 && value < 4000)
                    {
                        qUdel = 0.47;
                    }
                    else if (value >= 4000 && value < 4500)
                    {
                        qUdel = 0.46;
                    }
                    else if (value >= 4500 && value < 5000)
                    {
                        qUdel = 0.45;
                    }
                    else if (value >= 5000 && value < 6000)
                    {
                        qUdel = 0.43;
                    }
                    else if (value >= 6000 && value < 7000)
                    {
                        qUdel = 0.42;
                    }
                    else if (value >= 7000 && value < 8000)
                    {
                        qUdel = 0.41;
                    }
                    else if (value >= 8000 && value < 9000)
                    {
                        qUdel = 0.4;
                    }
                    else if (value >= 9000 && value < 10000)
                    {
                        qUdel = 0.39;
                    }
                    else if (value >= 10000 && value < 11000)
                    {
                        qUdel = 0.38;
                    }
                    else if (value >= 11000 && value < 12000)
                    {
                        qUdel = 0.38;
                    }
                    else if (value >= 12000 && value < 13000)
                    {
                        qUdel = 0.37;
                    }
                    else if (value >= 13000 && value < 14000)
                    {
                        qUdel = 0.37;
                    }
                    else if (value >= 14000 && value < 15000)
                    {
                        qUdel = 0.37;
                    }
                    else if (value >= 15000 && value < 20000)
                    {
                        qUdel = 0.37;
                    }
                    else if (value >= 20000 && value < 25000)
                    {
                        qUdel = 0.37;
                    }
                    else if (value >= 25000 && value < 30000)
                    {
                        qUdel = 0.36;
                    }
                    else if (value >= 30000 && value < 35000)
                    {
                        qUdel = 0.35;
                    }
                    else if (value >= 35000 && value < 40000)
                    {
                        qUdel = 0.35;
                    }
                    else if (value >= 40000 && value < 45000)
                    {
                        qUdel = 0.34;
                    }
                    else if (value >= 45000 && value < 50000)
                    {
                        qUdel = 0.34;
                    }
                    else if (value >= 50000)
                    {
                        qUdel = 0.34;
                    }
                }
                else
                {
                    if (value < 100)
                    {
                        qUdel = 0.74;
                    }
                    else if (value >= 100 && value < 200)
                    {
                        qUdel = 0.66;
                    }
                    else if (value >= 200 && value < 300)
                    {
                        qUdel = 0.62;
                    }
                    else if (value >= 300 && value < 400)
                    {
                        qUdel = 0.6;
                    }
                    else if (value >= 400 && value < 500)
                    {
                        qUdel = 0.58;
                    }
                    else if (value >= 500 && value < 600)
                    {
                        qUdel = 0.56;
                    }
                    else if (value >= 600 && value < 700)
                    {
                        qUdel = 0.54;
                    }
                    else if (value >= 700 && value < 800)
                    {
                        qUdel = 0.53;
                    }
                    else if (value >= 800 && value < 900)
                    {
                        qUdel = 0.52;
                    }
                    else if (value >= 900 && value < 1000)
                    {
                        qUdel = 0.51;
                    }
                    else if (value >= 1000 && value < 1100)
                    {
                        qUdel = 0.5;
                    }
                    else if (value >= 1100 && value < 1200)
                    {
                        qUdel = 0.49;
                    }
                    else if (value >= 1200 && value < 1300)
                    {
                        qUdel = 0.48;
                    }
                    else if (value >= 1300 && value < 1400)
                    {
                        qUdel = 0.47;
                    }
                    else if (value >= 1400 && value < 1500)
                    {
                        qUdel = 0.47;
                    }
                    else if (value >= 1500 && value < 1600)
                    {
                        qUdel = 0.47;
                    }
                    else if (value >= 1600 && value < 1700)
                    {
                        qUdel = 0.46;
                    }
                    else if (value >= 1700 && value < 2000)
                    {
                        qUdel = 0.45;
                    }
                    else if (value >= 2000 && value < 2500)
                    {
                        qUdel = 0.44;
                    }
                    else if (value >= 2500 && value < 3000)
                    {
                        qUdel = 0.43;
                    }
                    else if (value >= 3000 && value < 3500)
                    {
                        qUdel = 0.42;
                    }
                    else if (value >= 3500 && value < 4000)
                    {
                        qUdel = 0.4;
                    }
                    else if (value >= 4000 && value < 4500)
                    {
                        qUdel = 0.39;
                    }
                    else if (value >= 4500 && value < 5000)
                    {
                        qUdel = 0.38;
                    }
                    else if (value >= 5000 && value < 6000)
                    {
                        qUdel = 0.37;
                    }
                    else if (value >= 6000 && value < 7000)
                    {
                        qUdel = 0.36;
                    }
                    else if (value >= 7000 && value < 8000)
                    {
                        qUdel = 0.35;
                    }
                    else if (value >= 8000 && value < 9000)
                    {
                        qUdel = 0.34;
                    }
                    else if (value >= 9000 && value < 10000)
                    {
                        qUdel = 0.33;
                    }
                    else if (value >= 10000 && value < 11000)
                    {
                        qUdel = 0.32;
                    }
                    else if (value >= 11000 && value < 12000)
                    {
                        qUdel = 0.31;
                    }
                    else if (value >= 12000 && value < 13000)
                    {
                        qUdel = 0.3;
                    }
                    else if (value >= 13000 && value < 14000)
                    {
                        qUdel = 0.3;
                    }
                    else if (value >= 14000 && value < 15000)
                    {
                        qUdel = 0.29;
                    }
                    else if (value >= 15000 && value < 20000)
                    {
                        qUdel = 0.28;
                    }
                    else if (value >= 20000 && value < 25000)
                    {
                        qUdel = 0.28;
                    }
                    else if (value >= 25000 && value < 30000)
                    {
                        qUdel = 0.28;
                    }
                    else if (value >= 30000 && value < 35000)
                    {
                        qUdel = 0.28;
                    }
                    else if (value >= 35000 && value < 40000)
                    {
                        qUdel = 0.27;
                    }
                    else if (value >= 40000 && value < 45000)
                    {
                        qUdel = 0.27;
                    }
                    else if (value >= 45000 && value < 50000)
                    {
                        qUdel = 0.27;
                    }
                    else if (value >= 50000)
                    {
                        qUdel = 0.26;
                    }
                }
            }
            return qUdel;
        }

        public double CalculateCoofInfiltrationg()
        {
            coefInfiltration = 0.01* Math.Sqrt(2*g*freeHigh*(1 - (double)(273 + temp_out) / (273 + temp_in))+(speedOfWind*speedOfWind));
            return coefInfiltration;
        }

        public double CalculateQHot() {

             qHot = alfa * value * qUdel *( (temp_in - temp_out) * (1 + coefInfiltration)) * 0.000001;

            return qHot;
        }

        public double CalculateEnergy() {


            midleHotEnergy = (qHot * 24 * (temp_in - temp_midle) * countDays) / (temp_in - temp_out);

            return midleHotEnergy;
        }

        public double CalculateEnergy(double summEnergy)
        {


            midleHotEnergy = (summEnergy * 24 * (temp_in - temp_midle) * countDays) / (temp_in - temp_out);

            return midleHotEnergy;
        }

        public decimal CalculateTotalCost() {

            totalCoast =(decimal) CalculateEnergy() * costOne;
            return totalCoast;
        }

        public decimal CalculateTotalCost(double sum)
        {

            totalCoast = (decimal)CalculateEnergy(sum) * costOne;
            return totalCoast;
        }

    }
}
