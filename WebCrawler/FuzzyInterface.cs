using System;
using System.Collections.Generic;
using System.Text;
using AForge.Fuzzy;
//.................................................................................................................
namespace FIS
{
    class FuzzyInterfaceSystem
    {
//.................................................................................................................
        public double PageSimilarity(int Dist, double Freq)
        {
            //input distance
            FuzzySet DisLow = new FuzzySet("Low", new TrapezoidalFunction(1.5, 2.5, TrapezoidalFunction.EdgeType.Right));
            FuzzySet DisMiddle = new FuzzySet("Middle", new TrapezoidalFunction(1.5, 2.5, 3.5, 4.5));
            FuzzySet DisHigh = new FuzzySet("High", new TrapezoidalFunction(3.5, 4.5, TrapezoidalFunction.EdgeType.Left));
            LinguisticVariable Distance = new LinguisticVariable("Distance", 0, 6);
            Distance.AddLabel(DisLow);
            Distance.AddLabel(DisMiddle);
            Distance.AddLabel(DisHigh);
            //input frequency
            FuzzySet FerqVeryLow = new FuzzySet("VeryLow", new TrapezoidalFunction(0.15, 0.25, TrapezoidalFunction.EdgeType.Right));
            FuzzySet FerqLow = new FuzzySet("Low", new TrapezoidalFunction(0.15, 0.25, 0.35, 0.45));
            FuzzySet FerqMiddle = new FuzzySet("Middle", new TrapezoidalFunction(0.35, 0.45, 0.55, 0.65));
            FuzzySet FerqHigh = new FuzzySet("High", new TrapezoidalFunction(0.55, 0.65, 0.75, 0.85));
            FuzzySet FerqVeryHigh = new FuzzySet("VeryHigh", new TrapezoidalFunction(0.75, 0.85, TrapezoidalFunction.EdgeType.Left));
            LinguisticVariable Frequency = new LinguisticVariable("Frequency", 0, 1);
            Frequency.AddLabel(FerqVeryLow);
            Frequency.AddLabel(FerqLow);
            Frequency.AddLabel(FerqMiddle);
            Frequency.AddLabel(FerqHigh);
            Frequency.AddLabel(FerqVeryHigh);
            //similarity Output
            FuzzySet SimVeryLow = new FuzzySet("VeryLow", new TrapezoidalFunction(0.05, 0.2, TrapezoidalFunction.EdgeType.Right));
            FuzzySet SimLow = new FuzzySet("Low", new TrapezoidalFunction(0.05, 0.2, 0.3, 0.45));
            FuzzySet SimMiddle = new FuzzySet("Middle", new TrapezoidalFunction(0.3, 0.45, 0.55, 0.7));
            FuzzySet SimHigh = new FuzzySet("High", new TrapezoidalFunction(0.55, 0.7, 0.8, 0.95));
            FuzzySet SimVeryHigh = new FuzzySet("VeryHigh", new TrapezoidalFunction(0.8, 0.95, TrapezoidalFunction.EdgeType.Left));
            LinguisticVariable Similarity = new LinguisticVariable("Similarity", 0, 1);
            Similarity.AddLabel(SimVeryLow);
            Similarity.AddLabel(SimLow);
            Similarity.AddLabel(SimMiddle);
            Similarity.AddLabel(SimHigh);
            Similarity.AddLabel(SimVeryHigh);
            //database
            Database FuzzyDB = new Database();
            FuzzyDB.AddVariable(Distance);
            FuzzyDB.AddVariable(Frequency);
            FuzzyDB.AddVariable(Similarity);
            //creating the inference system
            InferenceSystem FIS = new InferenceSystem(FuzzyDB, new CentroidDefuzzifier(1000));
            FIS.NewRule("Rule 1", "IF Distance IS Low AND Frequency IS VeryHigh THEN Similarity IS VeryHigh");
            FIS.NewRule("Rule 2", "IF Distance IS Low AND Frequency IS High THEN Similarity IS High");
            FIS.NewRule("Rule 3", "IF Distance IS Low AND Frequency IS Middle THEN Similarity IS Middle");
            FIS.NewRule("Rule 4", "IF Distance IS Low AND Frequency IS Low THEN Similarity IS Low");
            FIS.NewRule("Rule 5", "IF Distance IS Low AND Frequency IS VeryLow THEN Similarity IS VeryLow");
            FIS.NewRule("Rule 6", "IF Distance IS Middle AND Frequency IS VeryHigh THEN Similarity IS High");
            FIS.NewRule("Rule 7", "IF Distance IS Middle AND Frequency IS High THEN Similarity IS High");
            FIS.NewRule("Rule 8", "IF Distance IS Middle AND Frequency IS Middle THEN Similarity IS Middle");
            FIS.NewRule("Rule 9", "IF Distance IS Middle AND Frequency IS Low THEN Similarity IS Low");
            FIS.NewRule("Rule 10", "IF Distance IS Middle AND Frequency IS VeryLow THEN Similarity IS VeryLow");
            FIS.NewRule("Rule 11", "IF Distance IS High AND Frequency IS VeryHigh THEN Similarity IS Middle");
            FIS.NewRule("Rule 12", "IF Distance IS High AND Frequency IS High THEN Similarity IS Middle");
            FIS.NewRule("Rule 13", "IF Distance IS High AND Frequency IS Middle THEN Similarity IS Low");
            FIS.NewRule("Rule 14", "IF Distance IS High AND Frequency IS Low THEN Similarity IS Low");
            FIS.NewRule("Rule 15", "IF Distance IS High AND Frequency IS VeryLow THEN Similarity IS VeryLow");
            //setting inputs
            FIS.SetInput("Distance", Dist);
            FIS.SetInput("Frequency", Freq);
            //getting outputs
            double newAngle = FIS.Evaluate("Similarity");
            return (Math.Round(newAngle, 2));
        }
//.................................................................................................................
    }
}
