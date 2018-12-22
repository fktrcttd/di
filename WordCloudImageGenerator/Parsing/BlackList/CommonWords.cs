namespace WordCloudImageGenerator.Parsing.BlackList
{
    public class CommonWords : CommonBlacklist
    {
        private static readonly string[] TopCommonWords =
            new[]
            {
                "�",
                "�",
                "��",
                "��",
                "��",
                "�",
                "���",
                "���",
                "����",
                "�",
                "�",
                "����",
                "���",
                "���",
                "���",
                "��",
                "��",
                "���",
                "�",
                "�",
                "��",
                "��",
                "��",
                "��",
                "��",
                "���",
                "��",
                "��",
                "���",
                "�����"
            };

        public CommonWords()
            : base(TopCommonWords)
        {
        }
    }
}