using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IyaAdmin.Models;

public class Word
{
    public Word()
    {
        TheWord = string.Empty;
        KanjiReadings = new List<KanjiReading>();
        Meanings = new List<Meaning>();
        OtherForms = new List<string>();
        Comment = string.Empty;
        SearchStr = string.Empty;
    }

    public int Id { get; set; }
    public string TheWord { get; set; }
    public List<KanjiReading> KanjiReadings { get; set; }
    public List<Meaning> Meanings { get; set; }
    public List<string> OtherForms { get; set; }
    public string Comment { get; set; }
    public string SearchStr { get; set; }
}

public class Meaning
{
    public Meaning()
    {
        Definition = string.Empty;
        Example = string.Empty;
    }

    public GrammaticalCategories Category { get; set; }
    public Tags Tag { get; set; }
    public string Definition { get; set; }
    public string Example { get; set; }
}

public class KanjiReading
{
    public KanjiReading()
    {
        Kanji = string.Empty;
        Reading = string.Empty;
    }

    public KanjiReading(string kanji, string reading)
    {
        Kanji = kanji;
        Reading = reading;
    }

    public static KanjiReading BuildFromString(string str)
    {
        return new KanjiReading();
    }

    public string Kanji { get; set; }
    public string Reading { get; set; }
}

public enum GrammaticalCategories
{
    None,
    SustantivoComun,
    SustantivoPropio,
    AdjetivoNa,
    AdjetivoI,
    AdjetivalNO,
    AdjetivoPrenominal,
    Adverbio,
    AdverbioTO,
    VerboGodanTransitivo,
    VerboGodanIntransitivo,
    VerboIchidanTransitivo,
    VerboIchidanIntransitivo,
    VerboIrregular,
    SustantivoVerbalSURU,
    Auxiliar,
    Pronombre,
    Determinante,
    Cuantificador,
    Conjuncion,
    Adposicion,
    Interjeccion,
    Ideofono,
    Prefijo,
    Sufijo,
    Expresion,
    Contador
}

public enum Tags
{
    None,
    Arcaico,
    Peyorativo,
    Sonkeigo,
    Kenjougo,
    JergaDeInternet,
    JergaDeMangaAnime
}
