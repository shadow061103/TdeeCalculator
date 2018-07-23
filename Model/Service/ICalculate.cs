﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public interface ICalculate
    {
        double CalculateBMR(Human human);
        double CalculateTdee(Human human);
        Nutrition CalculateNutrition(Human human);
    }
}
