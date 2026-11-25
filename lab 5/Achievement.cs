public class Achievement
{
    public int ClubId { get; set; }
    public int Gold { get; set; }
    public int Silver { get; set; }
    public int Bronze { get; set; }
    public int Cup { get; set; }
    public int CupFinal { get; set; }
    public int ChampionsLeague { get; set; }
    public int CLFinal { get; set; }
    public int EuropaLeague { get; set; }
    public int ELFinal { get; set; }
    public int CupWinners { get; set; }
    public int CWFinal { get; set; }
    public int ConferenceLeague { get; set; }
    public int ConfFinal { get; set; }

    public Achievement()
    {
    }

    public override string ToString()
    {
        return "ID клуба: " + ClubId
                            + ", З: " + Gold
                            + ", С: " + Silver
                            + ", Б: " + Bronze
                            + ", К: " + Cup
                            + ", ФК: " + CupFinal
                            + ", ЛЧ: " + ChampionsLeague
                            + ", ФЛЧ: " + CLFinal
                            + ", ЛЕ: " + EuropaLeague
                            + ", ФЛЕ: " + ELFinal
                            + ", КОК: " + CupWinners
                            + ", ФКОК: " + CWFinal
                            + ", ЛК: " + ConferenceLeague
                            + ", ФЛК: " + ConfFinal;
    }
}