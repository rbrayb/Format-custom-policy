using System;
using System.IO;
using System.Text;

namespace B2C_Format_Custom_Policy
{
    class Program
    {
        static string formattedText = "";

        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                System.Console.WriteLine("\nFormat is Input-file Output-file\n");
                return;
            }

            string inputFilePath = args[0];
            string outputFilePath = args[1];

            string originalText = File.ReadAllText(inputFilePath);

            StringBuilder sb = new StringBuilder(originalText);

            sb.Replace("</ClaimType>", "</ClaimType>" + Environment.NewLine);
            sb.Replace("</Predicate>", "</Predicate>" + Environment.NewLine);
            sb.Replace("</Predicates>", "</Predicates>" + Environment.NewLine);
            sb.Replace("</PredicateValidation>", "</PredicateValidation>" + Environment.NewLine);
            sb.Replace("</ClaimsTransformation>", "</ClaimsTransformation>" + Environment.NewLine);
            sb.Replace("</LocalizedResources>", "</LocalizedResources>" + Environment.NewLine);
            sb.Replace("</Localization>", "</Localization>" + Environment.NewLine);
            sb.Replace("</ContentDefinitions>", "</ContentDefinitions>" + Environment.NewLine);
            sb.Replace("</ClaimsTransformation>", "</ClaimsTransformation>" + Environment.NewLine);
            sb.Replace("</ClientDefinitions>", "</ClientDefinitions>" + Environment.NewLine);
            sb.Replace("</ContentDefinition>", "</ContentDefinition>" + Environment.NewLine);
            sb.Replace("</BuildingBlocks>", "</BuildingBlocks>" + Environment.NewLine);
            sb.Replace("</TechnicalProfile>", "</TechnicalProfile>" + Environment.NewLine);
            sb.Replace("</DisplayControl>", "</DisplayControl>" + Environment.NewLine);
            sb.Replace("</ClaimsProvider>", "</ClaimsProvider>" + Environment.NewLine);
            sb.Replace("</ClaimsProviders>", "</ClaimsProviders>" + Environment.NewLine);
            sb.Replace("</OrchestrationStep>", "</OrchestrationStep>" + Environment.NewLine);
            sb.Replace("</UserJourney>", "</UserJourney>" + Environment.NewLine);
            sb.Replace("</UserJourneys>", "</UserJourneys>" + Environment.NewLine);
            sb.Replace("</SubJourney>", "</SubJourney>" + Environment.NewLine);            

            formattedText = sb.ToString();

            File.WriteAllText(outputFilePath, formattedText, Encoding.UTF8);

            Console.WriteLine("\nProcessing complete. Press any key\n");

            Console.ReadLine();            

        }
    }
}
