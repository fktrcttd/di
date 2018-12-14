using System.Collections.Generic;

namespace WordCloud.TextAnalyze.Words
{
    public class Word : IWord
    {
        public string Text { get; private set; }
        public int Entries { get; private set; }

        public Word(KeyValuePair<string, int> textOccurrencesPair)
            : this(textOccurrencesPair.Key, textOccurrencesPair.Value)
        {
        }

        public Word(string text, int entries)
        {
            Text = text;
            Entries = entries;
        }
        
        public int CompareTo(IWord other)
        {
            return Entries - other.Entries;
        }

        public string GetCaption()
        {
            return $"{Entries} - entries";
        }
    }
}