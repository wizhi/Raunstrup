﻿using System;
using System.Collections.Generic;
using Raunstrup.Core.Domain;
using Raunstrup.Core.Repos;

namespace Raunstrup.Core.statistics
{
    public class ProjectComparison
    {
        private Project project;
        private List<ProjectComparisonLine> comparisonLines = new List<ProjectComparisonLine>(); 
        public ProjectComparison(Project project, ReportRepo repo)
        {
            List<Report> reports = repo.getByProject(project);
            this.project = project;
            CompareProject(reports);
        }

        private void CompareProject(List<Report> reports)
        {
            //Create dictionary which maps items to the amount of them in the order
            //This is neccesary because there can be multiple orderlines with them same item
            List<OrderLine> orderLines = project.GetDraft().GetOrderLines();
            Dictionary<Product,int> amountsInOrderlines = new Dictionary<Product, int>();
            foreach (var line in orderLines)
            {
                if (amountsInOrderlines.ContainsKey(line.getLineItem()))
                {
                    amountsInOrderlines[line.getLineItem()] += line.getQuantity();
                }
                else
                {
                    amountsInOrderlines.Add(line.getLineItem(), line.getQuantity()); 
                }
            }
            //Do the same for the report lines
            Dictionary<Product,int> amountsInReportLines = new Dictionary<Product, int>();
            foreach (var report in reports)
            {
                foreach (var line in report.getLines())
                {
                    if (amountsInReportLines.ContainsKey(line.getLineItem()))
                    {
                        amountsInReportLines[line.getLineItem()] += line.getQuantity();
                    }
                    else
                    {
                        amountsInReportLines.Add(line.getLineItem(), line.getQuantity());
                    }
                }
            }
            //Add the statistic lines
            foreach (var pair in amountsInOrderlines)
            {
                if (amountsInReportLines.ContainsKey(pair.Key))
                {
                    comparisonLines.Add(new ProjectComparisonLine(pair.Key,pair.Value,amountsInReportLines[pair.Key]));
                }
                else
                {
                    comparisonLines.Add(new ProjectComparisonLine(pair.Key, pair.Value, 0));
                }
            }


        }

        public void print()
        {
            // Print Lines
            foreach (var line in comparisonLines)
            {
                line.printLine();
            }
            //Print total
            Console.WriteLine(getTotalPercent());
        }
        public double getTotalPercent()
        {
            int totalOrder = 0;
            int totalUsed = 0;
            foreach (var line in comparisonLines)
            {
                totalOrder += line.getOrdered();
                totalUsed += line.getUsed();
            }
            return ((Convert.ToDouble(totalUsed) / Convert.ToDouble(totalOrder)) * 100);
        }
        public List<ProjectComparisonLine> getComparisonLines()
        {
            return comparisonLines;
        }
    }

    public class ProjectComparisonLine
    {
        private Product item;
        private int amountOrdered;
        private int amountUsed;

        public ProjectComparisonLine(Product item, int amountOrdered, int amountUsed)
        {
            this.item = item;
            this.amountOrdered = amountOrdered;
            this.amountUsed = amountUsed;
        }

        public double calculatePercentage()
        {
            return (Convert.ToDouble(amountUsed) / Convert.ToDouble(amountOrdered)) * 100;
        }

        public void printLine()
        {
            Console.WriteLine(item.getName() + " : " + amountOrdered + " : " + amountUsed + " : " + calculatePercentage() + "%");
        }

        public int getOrdered()
        {
            return amountOrdered;
        }

        public int getUsed()
        {
            return amountUsed;
        }
    }
}
