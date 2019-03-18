using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP_2
{
    struct Statistic
    {
        public double time;
        public int N;

        public Statistic(double time, int N)
        {
            this.time = time;
            this.N = N;
        }
    }

    class Simulation
    {
        public List<Statistic> Simulate(double l, double endTime)
        {
            double r, tau, lyambda = l / 24, t = 0.0; // матожидание = 1/лямбда (24/8=3) 8 в сутки, а не в час
            int N = 0;
            Random random = new Random();
            List<Statistic> statistics = new List<Statistic>();
            statistics.Add(new Statistic(0.0, 0));

            while (t <= endTime)
            {
                r = random.NextDouble();
                tau = (-1 / lyambda) * Math.Log(r);
                t += tau;
                N++;
                statistics.Add(new Statistic(t, N));
            }
            return statistics;
        }
    }
}