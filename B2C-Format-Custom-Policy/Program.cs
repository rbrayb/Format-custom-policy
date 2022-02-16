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

            // This text is always added, making the file longer over time
            // if it is not deleted.
            //string appendText = "This is extra text" + Environment.NewLine;
            //File.AppendAllText(path, appendText, Encoding.UTF8);

            // Open the file to read from.
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
            //sb.Replace("</UserJourney>", "</UserJourney>" + Environment.NewLine);
            //sb.Replace("</UserJourney>", "</UserJourney>" + Environment.NewLine);

            formattedText = sb.ToString();

            //formattedText = formattedText + originalText.Replace("</ClaimType>", "</ClaimType>" + Environment.NewLine);

            //formattedText = originalText.Replace("</ClaimsTransformation>", "</ClaimsTransformation>" + Environment.NewLine);

            //formattedText = originalText.Replace("</ClientDefinitions>", "</ClientDefinitions>" + Environment.NewLine);

            //formattedText = originalText.Replace("</ContentDefinition>", "</ContentDefinition>" + Environment.NewLine);

            //formattedText = originalText.Replace("</BuildingBlocks>", "</BuildingBlocks>" + Environment.NewLine);

            //formattedText = originalText.Replace("</TechnicalProfile>", "</TechnicalProfile>" + Environment.NewLine);

            //formattedText = originalText.Replace("</ClaimsProvider>", "</ClaimsProvider>" + Environment.NewLine);

            //formattedText = originalText.Replace("</ClaimsProviders>", "</ClaimsProviders>" + Environment.NewLine);

            //formattedText = originalText.Replace("</OrchestrationStep>", "</OrchestrationStep>" + Environment.NewLine);

            //formattedText = originalText.Replace("</UserJourney>", "</UserJourney>" + Environment.NewLine);           


            File.WriteAllText(outputFilePath, formattedText, Encoding.UTF8);
            

        }
    }
}
