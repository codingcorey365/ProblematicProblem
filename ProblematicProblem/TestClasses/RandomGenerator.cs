using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;

namespace ProblematicProblem.TestClasses;
public class RandomGenerator
{
    public string RandomNumber(List<string> activity)
    {
        Random rng = new Random();
        int randomNumber = rng.Next(activity.Count);
        string randomActivity = activity[randomNumber];
        return randomActivity;
    }
}