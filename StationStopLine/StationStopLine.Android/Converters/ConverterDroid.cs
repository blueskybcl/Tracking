using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;

namespace StationStopLine.Droid.Converters
{
    public static class ConverterDroid
    {
        public static ISpanned HtmlToSpanned(string htmlString)
        {
            ISpanned spanned = Html.FromHtml(htmlString, FromHtmlOptions.ModeCompact);
            return spanned;
        }

        public static string SpannedToHtml(ISpanned spanned)
        {
            string htmlString = Html.ToHtml(spanned, ToHtmlOptions.ParagraphLinesIndividual);
            string cleanString = CleanHtml(htmlString);
            return cleanString;
        }

        static string CleanHtml(string htmlString)
        {
            bool inTag = false;
            bool pTag = false;
            string newString = "";

            foreach (char c in htmlString)
            {
                if (c == '<')
                {
                    inTag = true;
                    newString += c;
                }
                else if (inTag)
                {
                    if (!pTag)
                    {
                        if (c == 'p')
                        {
                            pTag = true;
                        }
                        newString += c;
                    }
                    if (c == '>')
                    {
                        inTag = false;
                        pTag = false;
                        newString += c;
                    }
                }
                else
                {
                    newString += c;
                }
            }
            return newString;
        }

        public static FormattedString SpannedToFormatted(ISpanned spanned)
        {
            FormattedString formatted = (FormattedString)spanned;
            return formatted;
        }

        public static ISpanned FormattedToSpanned(FormattedString formatted)
        {
            ISpanned spanned = (ISpanned)formatted;
            return spanned;
        }
    }
}