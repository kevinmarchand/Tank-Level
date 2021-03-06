﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MathNet;
using MathNet.Numerics;

namespace TankLevel.Models
{
    public class ChartRepository
    {
        private List<ChartData> repositoryData1;
        private List<ChartData> repositoryData2;
        private List<ChartData> repositoryData3;
        private Tuple<double, double> f;
        private double[] xdata;
        private double[] ydata;
        private double goodnessFit;

        public ChartRepository()
        {
            GenerateData();
        }

        public List<ChartData> GetData1 { get { return repositoryData1; } }
        public List<ChartData> GetData2 { get { return repositoryData2; } }
        public List<ChartData> GetData3 { get { return repositoryData3; } }
        public Tuple<double,double> Function { get { return f; } }
        public double GoodnessFit { get { return goodnessFit; } }

        private void GenerateData()
        {
            repositoryData1 = new List<ChartData>()
            {
                new ChartData{Category=new DateTime(2017,12,16,10,0,0),Value=30},
                new ChartData{Category=new DateTime(2017,12,16,11,0,0),Value=35},
                new ChartData{Category=new DateTime(2017,12,16,12,0,0),Value=40},
                new ChartData{Category=new DateTime(2017,12,16,13,0,0),Value=45},
                new ChartData{Category=new DateTime(2017,12,16,14,0,0),Value=50},
                new ChartData{Category=new DateTime(2017,12,16,15,0,0),Value=55},
                new ChartData{Category=new DateTime(2017,12,16,16,0,0),Value=60},
                new ChartData{Category=new DateTime(2017,12,16,17,0,0),Value=65},
                new ChartData{Category=new DateTime(2017,12,16,18,0,0),Value=70},
                new ChartData{Category=new DateTime(2017,12,16,19,0,0),Value=75},
                new ChartData{Category=new DateTime(2017,12,16,20,0,0),Value=80},
                new ChartData{Category=new DateTime(2017,12,16,21,0,0),Value=15},
                new ChartData{Category=new DateTime(2017,12,16,22,0,0),Value=20},
                new ChartData{Category=new DateTime(2017,12,16,23,0,0),Value=25},
                new ChartData{Category=new DateTime(2017,12,17,0,0,0),Value=30},
                new ChartData{Category=new DateTime(2017,12,17,1,0,0),Value=35},
                new ChartData{Category=new DateTime(2017,12,17,2,0,0),Value=40},
                new ChartData{Category=new DateTime(2017,12,17,3,0,0),Value=45},
                new ChartData{Category=new DateTime(2017,12,17,4,0,0),Value=50},
                new ChartData{Category=new DateTime(2017,12,17,5,0,0),Value=55},
                new ChartData{Category=new DateTime(2017,12,17,6,0,0),Value=60},
                new ChartData{Category=new DateTime(2017,12,17,7,0,0),Value=65},
                new ChartData{Category=new DateTime(2017,12,17,8,0,0),Value=70},
                new ChartData{Category=new DateTime(2017,12,17,9,0,0),Value=70},
                new ChartData{Category=new DateTime(2017,12,17,10,0,0),Value=70},
                new ChartData{Category=new DateTime(2017,12,17,11,0,0),Value=70},
                new ChartData{Category=new DateTime(2017,12,17,12,0,0),Value=70},
                new ChartData{Category=new DateTime(2017,12,17,13,0,0),Value=70},
                new ChartData{Category=new DateTime(2017,12,17,14,0,0),Value=70},
                new ChartData{Category=new DateTime(2017,12,17,15,0,0),Value=75},
                new ChartData{Category=new DateTime(2017,12,17,16,0,0),Value=80},
                new ChartData{Category=new DateTime(2017,12,17,17,0,0),Value=85},
                new ChartData{Category=new DateTime(2017,12,17,18,0,0),Value=90},
                new ChartData{Category=new DateTime(2017,12,17,19,0,0),Value=10},
                new ChartData{Category=new DateTime(2017,12,17,20,0,0),Value=10},
                new ChartData{Category=new DateTime(2017,12,17,21,0,0),Value=10},
                new ChartData{Category=new DateTime(2017,12,17,22,0,0),Value=10},
                new ChartData{Category=new DateTime(2017,12,17,23,0,0),Value=15},
                new ChartData{Category=new DateTime(2017,12,18,0,0,0),Value=20},
                new ChartData{Category=new DateTime(2017,12,18,1,0,0),Value=25},
                new ChartData{Category=new DateTime(2017,12,18,2,0,0),Value=30},
                new ChartData{Category=new DateTime(2017,12,18,3,0,0),Value=35},
                new ChartData{Category=new DateTime(2017,12,18,4,0,0),Value=40},
                new ChartData{Category=new DateTime(2017,12,18,5,0,0),Value=45},
                new ChartData{Category=new DateTime(2017,12,18,6,0,0),Value=50},
                new ChartData{Category=new DateTime(2017,12,18,7,0,0),Value=55},
                new ChartData{Category=new DateTime(2017,12,18,8,0,0),Value=60},
                new ChartData{Category=new DateTime(2017,12,18,9,0,0),Value=65}
            };
            repositoryData2 = new List<ChartData>()
            {
                new ChartData{Category=new DateTime(2017,12,16,10,0,0),Value=30},
                new ChartData{Category=new DateTime(2017,12,16,11,0,0),Value=35},
                new ChartData{Category=new DateTime(2017,12,16,12,0,0),Value=40},
                new ChartData{Category=new DateTime(2017,12,16,13,0,0),Value=45},
                new ChartData{Category=new DateTime(2017,12,16,14,0,0),Value=50},
                new ChartData{Category=new DateTime(2017,12,16,15,0,0),Value=55},
                new ChartData{Category=new DateTime(2017,12,16,16,0,0),Value=60},
                new ChartData{Category=new DateTime(2017,12,16,17,0,0),Value=65},
                new ChartData{Category=new DateTime(2017,12,16,18,0,0),Value=70},
                new ChartData{Category=new DateTime(2017,12,16,19,0,0),Value=75},
                new ChartData{Category=new DateTime(2017,12,16,20,0,0),Value=80},
                new ChartData{Category=new DateTime(2017,12,16,21,0,0),Value=15},
                new ChartData{Category=new DateTime(2017,12,16,22,0,0),Value=20},
                new ChartData{Category=new DateTime(2017,12,16,23,0,0),Value=25},
                new ChartData{Category=new DateTime(2017,12,17,0,0,0),Value=30},
                new ChartData{Category=new DateTime(2017,12,17,1,0,0),Value=35},
                new ChartData{Category=new DateTime(2017,12,17,2,0,0),Value=40},
                new ChartData{Category=new DateTime(2017,12,17,3,0,0),Value=45},
                new ChartData{Category=new DateTime(2017,12,17,4,0,0),Value=50},
                new ChartData{Category=new DateTime(2017,12,17,5,0,0),Value=55},
                new ChartData{Category=new DateTime(2017,12,17,6,0,0),Value=60},
                new ChartData{Category=new DateTime(2017,12,17,7,0,0),Value=65},
                new ChartData{Category=new DateTime(2017,12,17,8,0,0),Value=70},
                new ChartData{Category=new DateTime(2017,12,17,9,0,0),Value=70},
                new ChartData{Category=new DateTime(2017,12,17,10,0,0),Value=75},
                new ChartData{Category=new DateTime(2017,12,17,11,0,0),Value=80},
                new ChartData{Category=new DateTime(2017,12,17,12,0,0),Value=85},
                new ChartData{Category=new DateTime(2017,12,17,13,0,0),Value=90},
                new ChartData{Category=new DateTime(2017,12,17,14,0,0),Value=10},
                new ChartData{Category=new DateTime(2017,12,17,15,0,0),Value=15},
                new ChartData{Category=new DateTime(2017,12,17,16,0,0),Value=20},
                new ChartData{Category=new DateTime(2017,12,17,17,0,0),Value=25},
                new ChartData{Category=new DateTime(2017,12,17,18,0,0),Value=30},
                new ChartData{Category=new DateTime(2017,12,17,19,0,0),Value=35},
                new ChartData{Category=new DateTime(2017,12,17,20,0,0),Value=40},
                new ChartData{Category=new DateTime(2017,12,17,21,0,0),Value=45},
                new ChartData{Category=new DateTime(2017,12,17,22,0,0),Value=50},
                new ChartData{Category=new DateTime(2017,12,17,23,0,0),Value=55},
                new ChartData{Category=new DateTime(2017,12,18,0,0,0),Value=60},
                new ChartData{Category=new DateTime(2017,12,18,1,0,0),Value=65},
                new ChartData{Category=new DateTime(2017,12,18,2,0,0),Value=70},
                new ChartData{Category=new DateTime(2017,12,18,3,0,0),Value=75},
                new ChartData{Category=new DateTime(2017,12,18,4,0,0),Value=80},
                new ChartData{Category=new DateTime(2017,12,18,5,0,0),Value=85},
                new ChartData{Category=new DateTime(2017,12,18,6,0,0),Value=10},
                new ChartData{Category=new DateTime(2017,12,18,7,0,0),Value=10},
                new ChartData{Category=new DateTime(2017,12,18,8,0,0),Value=10},
                new ChartData{Category=new DateTime(2017,12,18,9,0,0),Value=10}
            };
            repositoryData3 = new List<ChartData>()
            {
                new ChartData{Category=new DateTime(2017,12,16,10,0,0),Value=30},
                new ChartData{Category=new DateTime(2017,12,16,11,0,0),Value=35},
                new ChartData{Category=new DateTime(2017,12,16,12,0,0),Value=40},
                new ChartData{Category=new DateTime(2017,12,16,13,0,0),Value=45},
                new ChartData{Category=new DateTime(2017,12,16,14,0,0),Value=50},
                new ChartData{Category=new DateTime(2017,12,16,15,0,0),Value=55},
                new ChartData{Category=new DateTime(2017,12,16,16,0,0),Value=60},
                new ChartData{Category=new DateTime(2017,12,16,17,0,0),Value=65},
                new ChartData{Category=new DateTime(2017,12,16,18,0,0),Value=70},
                new ChartData{Category=new DateTime(2017,12,16,19,0,0),Value=75},
                new ChartData{Category=new DateTime(2017,12,16,20,0,0),Value=80},
                new ChartData{Category=new DateTime(2017,12,16,21,0,0),Value=15},
                new ChartData{Category=new DateTime(2017,12,16,22,0,0),Value=20},
                new ChartData{Category=new DateTime(2017,12,16,23,0,0),Value=25},
                new ChartData{Category=new DateTime(2017,12,17,0,0,0),Value=30},
                new ChartData{Category=new DateTime(2017,12,17,1,0,0),Value=35},
                new ChartData{Category=new DateTime(2017,12,17,2,0,0),Value=40},
                new ChartData{Category=new DateTime(2017,12,17,3,0,0),Value=45},
                new ChartData{Category=new DateTime(2017,12,17,4,0,0),Value=50},
                new ChartData{Category=new DateTime(2017,12,17,5,0,0),Value=55},
                new ChartData{Category=new DateTime(2017,12,17,6,0,0),Value=60},
                new ChartData{Category=new DateTime(2017,12,17,7,0,0),Value=65},
                new ChartData{Category=new DateTime(2017,12,17,8,0,0),Value=70},
                new ChartData{Category=new DateTime(2017,12,17,9,0,0),Value=75},
                new ChartData{Category=new DateTime(2017,12,17,10,0,0),Value=80},
                new ChartData{Category=new DateTime(2017,12,17,11,0,0),Value=10},
                new ChartData{Category=new DateTime(2017,12,17,12,0,0),Value=15},
                new ChartData{Category=new DateTime(2017,12,17,13,0,0),Value=20},
                new ChartData{Category=new DateTime(2017,12,17,14,0,0),Value=25},
                new ChartData{Category=new DateTime(2017,12,17,15,0,0),Value=30},
                new ChartData{Category=new DateTime(2017,12,17,16,0,0),Value=35},
                new ChartData{Category=new DateTime(2017,12,17,17,0,0),Value=40},
                new ChartData{Category=new DateTime(2017,12,17,18,0,0),Value=45},
                new ChartData{Category=new DateTime(2017,12,17,19,0,0),Value=50},
                new ChartData{Category=new DateTime(2017,12,17,20,0,0),Value=50},
                new ChartData{Category=new DateTime(2017,12,17,21,0,0),Value=50},
                new ChartData{Category=new DateTime(2017,12,17,22,0,0),Value=50},
                new ChartData{Category=new DateTime(2017,12,17,23,0,0),Value=50},
                new ChartData{Category=new DateTime(2017,12,18,0,0,0),Value=50},
                new ChartData{Category=new DateTime(2017,12,18,1,0,0),Value=50},
                new ChartData{Category=new DateTime(2017,12,18,2,0,0),Value=50},
                new ChartData{Category=new DateTime(2017,12,18,3,0,0),Value=50},
                new ChartData{Category=new DateTime(2017,12,18,4,0,0),Value=55},
                new ChartData{Category=new DateTime(2017,12,18,5,0,0),Value=60},
                new ChartData{Category=new DateTime(2017,12,18,6,0,0),Value=65},
                new ChartData{Category=new DateTime(2017,12,18,7,0,0),Value=70},
                new ChartData{Category=new DateTime(2017,12,18,8,0,0),Value=75},
                new ChartData{Category=new DateTime(2017,12,18,9,0,0),Value=80}
            };
        }

        public void FindLowestIndexReverse(List<ChartData> data)
        {
            // Find the lowest value in the list
            int storeIndex = data.Count - 1;
            int storedata = data[storeIndex].Value;

            for (int i = data.Count - 2; i >= 0; i--)
            {
                if (storedata > data[i].Value)
                {
                    storeIndex = i;
                    storedata = data[i].Value;
                }
                else
                {
                    break;
                }
            }

            // Convert the list from the lowest value index to the last value
            // to a array of double
            List<double> xlist = new List<double>();
            List<double> ylist = new List<double>();

            for (int i = storeIndex; i < data.Count; i++)
            {
                xlist.Add(i-storeIndex);
                ylist.Add(Convert.ToDouble(data[i].Value));
            }

            xdata = xlist.ToArray<double>();
            ydata = ylist.ToArray<double>();

            // Linear regression
            if (xdata.Count() >= 2 && ydata.Count() >= 2)
            {
                f = Fit.Line(xdata, ydata);
                goodnessFit = GoodnessOfFit.RSquared(xdata.Select(x => f.Item1 + f.Item2 * x), ydata); // == 1.0
            }
        }

        public DateTime? EvaluateFunctionAt(double x, List<ChartData> data)
        {
            if (f != null)
            {
                if (f.Item2 != 0)
                {
                    DateTime lastDate = data[data.Count - 1].Category;
                    int lastIndex = xdata.Count() - 1;
                    double predictedIndex = ((x - f.Item1) / f.Item2);
                    DateTime predictedDate = lastDate.AddHours(predictedIndex - lastIndex);
                    return predictedDate;
                }
                else
                {
                    throw new DivideByZeroException();
                }
            }
            else
            {
                return null;
            }
        }
    }
}