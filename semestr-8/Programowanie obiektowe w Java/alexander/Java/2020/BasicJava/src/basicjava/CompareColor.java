package basicjava;

import java.awt.Color;
import java.util.ArrayList;
import java.util.HashMap;

public class CompareColor
{
    private static final ArrayList<ColorByName> lst=new ArrayList<ColorByName>()
    {
        {
            add(new SelectColorUseSwitch());
            add(new SelectColorUseDivide());
            add(new SelectColorUseMap());
        }
    };
    public static void compare()
    {
        for(ColorByName method:lst)
        {
            final long start=System.nanoTime();
            for(int i=0;i<100000;++i) method.get("");
            long time=System.nanoTime()-start;
            System.out.printf("%s: %d\n", lst.getClass().getName(),time);
        }
    }
}

class SelectColorUseSwitch implements ColorByName
{
    public Color get(String name)
    {
        switch(name)
        {
            case "lightsalmon": return new Color(255,160,122);
            case "salmon": return new Color(250,128,114);
            case "darksalmon": return new Color(233,150,122);
            case "lightcoral": return new Color(240,128,128);
            case "indianred": return new Color(205,92,92);
/*
            case "crimson": return new Color(220,20,60);
            case "firebrick": return new Color(178,34,34);
            case "red": return new Color(255,0,0);
            case "darkred": return new Color(139,0,0);
            case "coral": return new Color(255,127,80);
            case "tomato": return new Color(255,99,71);
            case "orangered": return new Color(255,69,0);
            case "gold": return new Color(255,215,0);
            case "orange": return new Color(255,165,0);
            case "darkorange": return new Color(255,140,0);
            case "lightyellow": return new Color(255,255,224);
            case "lemonchiffon": return new Color(255,250,205);
            case "lightgoldenrodyellow": return new Color(250,250,210);
            case "papayawhip": return new Color(255,239,213);
            case "moccasin": return new Color(255,228,181);
            case "peachpuff": return new Color(255,218,185);
            case "palegoldenrod": return new Color(238,232,170);
            case "khaki": return new Color(240,230,140);
            case "darkkhaki": return new Color(189,183,107);
            case "yellow": return new Color(255,255,0);
            case "lawngreen": return new Color(124,252,0);
            case "chartreuse": return new Color(127,255,0);
            case "limegreen": return new Color(50,205,50);
            case "lime": return new Color(0,255,0);
            case "forestgreen": return new Color(34,139,34);
            case "green": return new Color(0,128,0);
            case "darkgreen": return new Color(0,100,0);
            case "greenyellow": return new Color(173,255,47);
            case "yellowgreen": return new Color(154,205,50);
            case "springgreen": return new Color(0,255,127);
            case "mediumspringgreen": return new Color(0,250,154);
            case "lightgreen": return new Color(144,238,144);
            case "palegreen": return new Color(152,251,152);
            case "darkseagreen": return new Color(143,188,143);
            case "mediumseagreen": return new Color(60,179,113);
            case "seagreen": return new Color(46,139,87);
            case "olive": return new Color(128,128,0);
            case "darkolivegreen": return new Color(85,107,47);
            case "olivedrab": return new Color(107,142,35);
            case "lightcyan": return new Color(224,255,255);
            case "cyan": return new Color(0,255,255);
            case "aqua": return new Color(0,255,255);
            case "aquamarine": return new Color(127,255,212);
            case "mediumaquamarine": return new Color(102,205,170);
            case "paleturquoise": return new Color(175,238,238);
            case "turquoise": return new Color(64,224,208);
            case "mediumturquoise": return new Color(72,209,204);
            case "darkturquoise": return new Color(0,206,209);
            case "lightseagreen": return new Color(32,178,170);
            case "cadetblue": return new Color(95,158,160);
            case "darkcyan": return new Color(0,139,139);
            case "teal": return new Color(0,128,128);
            case "powderblue": return new Color(176,224,230);
            case "lightblue": return new Color(173,216,230);
            case "lightskyblue": return new Color(135,206,250);
            case "skyblue": return new Color(135,206,235);
            case "deepskyblue": return new Color(0,191,255);
            case "lightsteelblue": return new Color(176,196,222);
            case "dodgerblue": return new Color(30,144,255);
            case "cornflowerblue": return new Color(100,149,237);
            case "steelblue": return new Color(70,130,180);
            case "royalblue": return new Color(65,105,225);
            case "blue": return new Color(0,0,255);
            case "mediumblue": return new Color(0,0,205);
            case "darkblue": return new Color(0,0,139);
            case "navy": return new Color(0,0,128);
            case "midnightblue": return new Color(25,25,112);
            case "mediumslateblue": return new Color(123,104,238);
            case "slateblue": return new Color(106,90,205);
            case "darkslateblue": return new Color(72,61,139);
            case "lavender": return new Color(230,230,250);
            case "thistle": return new Color(216,191,216);
            case "plum": return new Color(221,160,221);
            case "violet": return new Color(238,130,238);
            case "orchid": return new Color(218,112,214);
            case "fuchsia": return new Color(255,0,255);
            case "magenta": return new Color(255,0,255);
            case "mediumorchid": return new Color(186,85,211);
            case "mediumpurple": return new Color(147,112,219);
            case "blueviolet": return new Color(138,43,226);
            case "darkviolet": return new Color(148,0,211);
            case "darkorchid": return new Color(153,50,204);
            case "darkmagenta": return new Color(139,0,139);
            case "purple": return new Color(128,0,128);
            case "indigo": return new Color(75,0,130);
            case "pink": return new Color(255,192,203);
            case "lightpink": return new Color(255,182,193);
            case "hotpink": return new Color(255,105,180);
            case "deeppink": return new Color(255,20,147);
            case "palevioletred": return new Color(219,112,147);
            case "mediumvioletred": return new Color(199,21,133);
            case "white": return new Color(255,255,255);
            case "snow": return new Color(255,250,250);
            case "honeydew": return new Color(240,255,240);
            case "mintcream": return new Color(245,255,250);
            case "azure": return new Color(240,255,255);
            case "aliceblue": return new Color(240,248,255);
            case "ghostwhite": return new Color(248,248,255);
            case "whitesmoke": return new Color(245,245,245);
            case "seashell": return new Color(255,245,238);
            case "beige": return new Color(245,245,220);
            case "oldlace": return new Color(253,245,230);
            case "floralwhite": return new Color(255,250,240);
            case "ivory": return new Color(255,255,240);
            case "antiquewhite": return new Color(250,235,215);
            case "linen": return new Color(250,240,230);
            case "lavenderblush": return new Color(255,240,245);
            case "mistyrose": return new Color(255,228,225);
            case "gainsboro": return new Color(220,220,220);
            case "lightgray": return new Color(211,211,211);
            case "silver": return new Color(192,192,192);
            case "darkgray": return new Color(169,169,169);
            case "gray": return new Color(128,128,128);
            case "dimgray": return new Color(105,105,105);
            case "lightslategray": return new Color(119,136,153);
            case "slategray": return new Color(112,128,144);
            case "darkslategray": return new Color(47,79,79);
            case "black": return new Color(0,0,0);
            case "cornsilk": return new Color(255,248,220);
            case "blanchedalmond": return new Color(255,235,205);
            case "bisque": return new Color(255,228,196);
            case "navajowhite": return new Color(255,222,173);
            case "wheat": return new Color(245,222,179);
            case "burlywood": return new Color(222,184,135);
            case "tan": return new Color(210,180,140);
            case "rosybrown": return new Color(188,143,143);
            case "sandybrown": return new Color(244,164,96);
            case "goldenrod": return new Color(218,165,32);
            case "peru": return new Color(205,133,63);
            case "chocolate": return new Color(210,105,30);
            case "saddlebrown": return new Color(139,69,19);
            case "sienna": return new Color(160,82,45);
            case "brown": return new Color(165,42,42);
            case "maroon": return new Color(128,0,0);
*/
        }
        return null;
    }
}

class SelectColorUseDivide implements ColorByName
{
    private final ArrayList<StringToColor> lst=new ArrayList<StringToColor>()
    {
        {
            add(new StringToColor("chartreuse",new Color(127,255,0)));
            add(new StringToColor("coral",new Color(255,127,80)));
            add(new StringToColor("crimson",new Color(220,20,60)));
            add(new StringToColor("darkkhaki",new Color(189,183,107)));
            add(new StringToColor("darkorange",new Color(255,140,0)));
            add(new StringToColor("darkred",new Color(139,0,0)));
            add(new StringToColor("darksalmon",new Color(233,150,122)));
            add(new StringToColor("firebrick",new Color(178,34,34)));
            add(new StringToColor("forestgreen",new Color(34,139,34)));
            add(new StringToColor("gold",new Color(255,215,0)));
            add(new StringToColor("indianred",new Color(205,92,92)));
            add(new StringToColor("khaki",new Color(240,230,140)));
            add(new StringToColor("lawngreen",new Color(124,252,0)));
            add(new StringToColor("lemonchiffon",new Color(255,250,205)));
            add(new StringToColor("lightcoral",new Color(240,128,128)));
            add(new StringToColor("lightgoldenrodyellow",new Color(250,250,210)));
            add(new StringToColor("lightsalmon",new Color(255,160,122)));
            add(new StringToColor("lightyellow",new Color(255,255,224)));
            add(new StringToColor("lime",new Color(0,255,0)));
            add(new StringToColor("limegreen",new Color(50,205,50)));
            add(new StringToColor("moccasin",new Color(255,228,181)));
            add(new StringToColor("orange",new Color(255,165,0)));
            add(new StringToColor("orangered",new Color(255,69,0)));
            add(new StringToColor("palegoldenrod",new Color(238,232,170)));
            add(new StringToColor("papayawhip",new Color(255,239,213)));
            add(new StringToColor("peachpuff",new Color(255,218,185)));
            add(new StringToColor("red",new Color(255,0,0)));
            add(new StringToColor("salmon",new Color(250,128,114)));
            add(new StringToColor("tomato",new Color(255,99,71)));
            add(new StringToColor("yellow",new Color(255,255,0)));
/*
            add(new StringToColor("green",new Color(0,128,0)));
            add(new StringToColor("darkgreen",new Color(0,100,0)));
            add(new StringToColor("greenyellow",new Color(173,255,47)));
            add(new StringToColor("yellowgreen",new Color(154,205,50)));
            add(new StringToColor("springgreen",new Color(0,255,127)));
            add(new StringToColor("mediumspringgreen",new Color(0,250,154)));
            add(new StringToColor("lightgreen",new Color(144,238,144)));
            add(new StringToColor("palegreen",new Color(152,251,152)));
            add(new StringToColor("darkseagreen",new Color(143,188,143)));
            add(new StringToColor("mediumseagreen",new Color(60,179,113)));
            add(new StringToColor("seagreen",new Color(46,139,87)));
            add(new StringToColor("olive",new Color(128,128,0)));
            add(new StringToColor("darkolivegreen",new Color(85,107,47)));
            add(new StringToColor("olivedrab",new Color(107,142,35)));
            add(new StringToColor("lightcyan",new Color(224,255,255)));
            add(new StringToColor("cyan",new Color(0,255,255)));
            add(new StringToColor("aqua",new Color(0,255,255)));
            add(new StringToColor("aquamarine",new Color(127,255,212)));
            add(new StringToColor("mediumaquamarine",new Color(102,205,170)));
            add(new StringToColor("paleturquoise",new Color(175,238,238)));
            add(new StringToColor("turquoise",new Color(64,224,208)));
            add(new StringToColor("mediumturquoise",new Color(72,209,204)));
            add(new StringToColor("darkturquoise",new Color(0,206,209)));
            add(new StringToColor("lightseagreen",new Color(32,178,170)));
            add(new StringToColor("cadetblue",new Color(95,158,160)));
            add(new StringToColor("darkcyan",new Color(0,139,139)));
            add(new StringToColor("teal",new Color(0,128,128)));
            add(new StringToColor("powderblue",new Color(176,224,230)));
            add(new StringToColor("lightblue",new Color(173,216,230)));
            add(new StringToColor("lightskyblue",new Color(135,206,250)));
            add(new StringToColor("skyblue",new Color(135,206,235)));
            add(new StringToColor("deepskyblue",new Color(0,191,255)));
            add(new StringToColor("lightsteelblue",new Color(176,196,222)));
            add(new StringToColor("dodgerblue",new Color(30,144,255)));
            add(new StringToColor("cornflowerblue",new Color(100,149,237)));
            add(new StringToColor("steelblue",new Color(70,130,180)));
            add(new StringToColor("royalblue",new Color(65,105,225)));
            add(new StringToColor("blue",new Color(0,0,255)));
            add(new StringToColor("mediumblue",new Color(0,0,205)));
            add(new StringToColor("darkblue",new Color(0,0,139)));
            add(new StringToColor("navy",new Color(0,0,128)));
            add(new StringToColor("midnightblue",new Color(25,25,112)));
            add(new StringToColor("mediumslateblue",new Color(123,104,238)));
            add(new StringToColor("slateblue",new Color(106,90,205)));
            add(new StringToColor("darkslateblue",new Color(72,61,139)));
            add(new StringToColor("lavender",new Color(230,230,250)));
            add(new StringToColor("thistle",new Color(216,191,216)));
            add(new StringToColor("plum",new Color(221,160,221)));
            add(new StringToColor("violet",new Color(238,130,238)));
            add(new StringToColor("orchid",new Color(218,112,214)));
            add(new StringToColor("fuchsia",new Color(255,0,255)));
            add(new StringToColor("magenta",new Color(255,0,255)));
            add(new StringToColor("mediumorchid",new Color(186,85,211)));
            add(new StringToColor("mediumpurple",new Color(147,112,219)));
            add(new StringToColor("blueviolet",new Color(138,43,226)));
            add(new StringToColor("darkviolet",new Color(148,0,211)));
            add(new StringToColor("darkorchid",new Color(153,50,204)));
            add(new StringToColor("darkmagenta",new Color(139,0,139)));
            add(new StringToColor("purple",new Color(128,0,128)));
            add(new StringToColor("indigo",new Color(75,0,130)));
            add(new StringToColor("pink",new Color(255,192,203)));
            add(new StringToColor("lightpink",new Color(255,182,193)));
            add(new StringToColor("hotpink",new Color(255,105,180)));
            add(new StringToColor("deeppink",new Color(255,20,147)));
            add(new StringToColor("palevioletred",new Color(219,112,147)));
            add(new StringToColor("mediumvioletred",new Color(199,21,133)));
            add(new StringToColor("white",new Color(255,255,255)));
            add(new StringToColor("snow",new Color(255,250,250)));
            add(new StringToColor("honeydew",new Color(240,255,240)));
            add(new StringToColor("mintcream",new Color(245,255,250)));
            add(new StringToColor("azure",new Color(240,255,255)));
            add(new StringToColor("aliceblue",new Color(240,248,255)));
            add(new StringToColor("ghostwhite",new Color(248,248,255)));
            add(new StringToColor("whitesmoke",new Color(245,245,245)));
            add(new StringToColor("seashell",new Color(255,245,238)));
            add(new StringToColor("beige",new Color(245,245,220)));
            add(new StringToColor("oldlace",new Color(253,245,230)));
            add(new StringToColor("floralwhite",new Color(255,250,240)));
            add(new StringToColor("ivory",new Color(255,255,240)));
            add(new StringToColor("antiquewhite",new Color(250,235,215)));
            add(new StringToColor("linen",new Color(250,240,230)));
            add(new StringToColor("lavenderblush",new Color(255,240,245)));
            add(new StringToColor("mistyrose",new Color(255,228,225)));
            add(new StringToColor("gainsboro",new Color(220,220,220)));
            add(new StringToColor("lightgray",new Color(211,211,211)));
            add(new StringToColor("silver",new Color(192,192,192)));
            add(new StringToColor("darkgray",new Color(169,169,169)));
            add(new StringToColor("gray",new Color(128,128,128)));
            add(new StringToColor("dimgray",new Color(105,105,105)));
            add(new StringToColor("lightslategray",new Color(119,136,153)));
            add(new StringToColor("slategray",new Color(112,128,144)));
            add(new StringToColor("darkslategray",new Color(47,79,79)));
            add(new StringToColor("black",new Color(0,0,0)));
            add(new StringToColor("cornsilk",new Color(255,248,220)));
            add(new StringToColor("blanchedalmond",new Color(255,235,205)));
            add(new StringToColor("bisque",new Color(255,228,196)));
            add(new StringToColor("navajowhite",new Color(255,222,173)));
            add(new StringToColor("wheat",new Color(245,222,179)));
            add(new StringToColor("burlywood",new Color(222,184,135)));
            add(new StringToColor("tan",new Color(210,180,140)));
            add(new StringToColor("rosybrown",new Color(188,143,143)));
            add(new StringToColor("sandybrown",new Color(244,164,96)));
            add(new StringToColor("goldenrod",new Color(218,165,32)));
            add(new StringToColor("peru",new Color(205,133,63)));
            add(new StringToColor("chocolate",new Color(210,105,30)));
            add(new StringToColor("saddlebrown",new Color(139,69,19)));
            add(new StringToColor("sienna",new Color(160,82,45)));
            add(new StringToColor("brown",new Color(165,42,42)));
            add(new StringToColor("maroon",new Color(128,0,0)));
*/
        }
    };
    public Color get(String name)
    {
        int min=0,max=lst.size();
        while(min<max)
        {
            int mid=(min+max)>>1;
            final StringToColor sc=lst.get(mid);
            int cmp=name.compareTo(sc.name);
            if(cmp>0) max=mid;
            else if(cmp<0) min=mid+1;
            else return sc.color;
        }
        return null;
    }
}

class SelectColorUseMap implements ColorByName
{
    private final HashMap<String,Color> map=new HashMap<String,Color>()
    {
        {
            put("lightsalmon",new Color(255,160,122));
            put("salmon",new Color(250,128,114));
            put("darksalmon",new Color(233,150,122));
            put("lightcoral",new Color(240,128,128));
            put("indianred",new Color(205,92,92));
/*            
            put("crimson",new Color(220,20,60));
            put("firebrick",new Color(178,34,34));
            put("red",new Color(255,0,0));
            put("darkred",new Color(139,0,0));
            put("coral",new Color(255,127,80));
            put("tomato",new Color(255,99,71));
            put("orangered",new Color(255,69,0));
            put("gold",new Color(255,215,0));
            put("orange",new Color(255,165,0));
            put("darkorange",new Color(255,140,0));
            put("lightyellow",new Color(255,255,224));
            put("lemonchiffon",new Color(255,250,205));
            put("lightgoldenrodyellow",new Color(250,250,210));
            put("papayawhip",new Color(255,239,213));
            put("moccasin",new Color(255,228,181));
            put("peachpuff",new Color(255,218,185));
            put("palegoldenrod",new Color(238,232,170));
            put("khaki",new Color(240,230,140));
            put("darkkhaki",new Color(189,183,107));
            put("yellow",new Color(255,255,0));
            put("lawngreen",new Color(124,252,0));
            put("chartreuse",new Color(127,255,0));
            put("limegreen",new Color(50,205,50));
            put("lime",new Color(0,255,0));
            put("forestgreen",new Color(34,139,34));
            put("green",new Color(0,128,0));
            put("darkgreen",new Color(0,100,0));
            put("greenyellow",new Color(173,255,47));
            put("yellowgreen",new Color(154,205,50));
            put("springgreen",new Color(0,255,127));
            put("mediumspringgreen",new Color(0,250,154));
            put("lightgreen",new Color(144,238,144));
            put("palegreen",new Color(152,251,152));
            put("darkseagreen",new Color(143,188,143));
            put("mediumseagreen",new Color(60,179,113));
            put("seagreen",new Color(46,139,87));
            put("olive",new Color(128,128,0));
            put("darkolivegreen",new Color(85,107,47));
            put("olivedrab",new Color(107,142,35));
            put("lightcyan",new Color(224,255,255));
            put("cyan",new Color(0,255,255));
            put("aqua",new Color(0,255,255));
            put("aquamarine",new Color(127,255,212));
            put("mediumaquamarine",new Color(102,205,170));
            put("paleturquoise",new Color(175,238,238));
            put("turquoise",new Color(64,224,208));
            put("mediumturquoise",new Color(72,209,204));
            put("darkturquoise",new Color(0,206,209));
            put("lightseagreen",new Color(32,178,170));
            put("cadetblue",new Color(95,158,160));
            put("darkcyan",new Color(0,139,139));
            put("teal",new Color(0,128,128));
            put("powderblue",new Color(176,224,230));
            put("lightblue",new Color(173,216,230));
            put("lightskyblue",new Color(135,206,250));
            put("skyblue",new Color(135,206,235));
            put("deepskyblue",new Color(0,191,255));
            put("lightsteelblue",new Color(176,196,222));
            put("dodgerblue",new Color(30,144,255));
            put("cornflowerblue",new Color(100,149,237));
            put("steelblue",new Color(70,130,180));
            put("royalblue",new Color(65,105,225));
            put("blue",new Color(0,0,255));
            put("mediumblue",new Color(0,0,205));
            put("darkblue",new Color(0,0,139));
            put("navy",new Color(0,0,128));
            put("midnightblue",new Color(25,25,112));
            put("mediumslateblue",new Color(123,104,238));
            put("slateblue",new Color(106,90,205));
            put("darkslateblue",new Color(72,61,139));
            put("lavender",new Color(230,230,250));
            put("thistle",new Color(216,191,216));
            put("plum",new Color(221,160,221));
            put("violet",new Color(238,130,238));
            put("orchid",new Color(218,112,214));
            put("fuchsia",new Color(255,0,255));
            put("magenta",new Color(255,0,255));
            put("mediumorchid",new Color(186,85,211));
            put("mediumpurple",new Color(147,112,219));
            put("blueviolet",new Color(138,43,226));
            put("darkviolet",new Color(148,0,211));
            put("darkorchid",new Color(153,50,204));
            put("darkmagenta",new Color(139,0,139));
            put("purple",new Color(128,0,128));
            put("indigo",new Color(75,0,130));
            put("pink",new Color(255,192,203));
            put("lightpink",new Color(255,182,193));
            put("hotpink",new Color(255,105,180));
            put("deeppink",new Color(255,20,147));
            put("palevioletred",new Color(219,112,147));
            put("mediumvioletred",new Color(199,21,133));
            put("white",new Color(255,255,255));
            put("snow",new Color(255,250,250));
            put("honeydew",new Color(240,255,240));
            put("mintcream",new Color(245,255,250));
            put("azure",new Color(240,255,255));
            put("aliceblue",new Color(240,248,255));
            put("ghostwhite",new Color(248,248,255));
            put("whitesmoke",new Color(245,245,245));
            put("seashell",new Color(255,245,238));
            put("beige",new Color(245,245,220));
            put("oldlace",new Color(253,245,230));
            put("floralwhite",new Color(255,250,240));
            put("ivory",new Color(255,255,240));
            put("antiquewhite",new Color(250,235,215));
            put("linen",new Color(250,240,230));
            put("lavenderblush",new Color(255,240,245));
            put("mistyrose",new Color(255,228,225));
            put("gainsboro",new Color(220,220,220));
            put("lightgray",new Color(211,211,211));
            put("silver",new Color(192,192,192));
            put("darkgray",new Color(169,169,169));
            put("gray",new Color(128,128,128));
            put("dimgray",new Color(105,105,105));
            put("lightslategray",new Color(119,136,153));
            put("slategray",new Color(112,128,144));
            put("darkslategray",new Color(47,79,79));
            put("black",new Color(0,0,0));
            put("cornsilk",new Color(255,248,220));
            put("blanchedalmond",new Color(255,235,205));
            put("bisque",new Color(255,228,196));
            put("navajowhite",new Color(255,222,173));
            put("wheat",new Color(245,222,179));
            put("burlywood",new Color(222,184,135));
            put("tan",new Color(210,180,140));
            put("rosybrown",new Color(188,143,143));
            put("sandybrown",new Color(244,164,96));
            put("goldenrod",new Color(218,165,32));
            put("peru",new Color(205,133,63));
            put("chocolate",new Color(210,105,30));
            put("saddlebrown",new Color(139,69,19));
            put("sienna",new Color(160,82,45));
            put("brown",new Color(165,42,42));
            put("maroon",new Color(128,0,0));
*/
        }
    };
    public Color get(String name)
    {
        return map.get(name);
    }
}

interface ColorByName
{
    Color get(String name);
}

class StringToColor
{
    public String name;
    public Color color;
    public StringToColor(String name, Color color) 
    {
        this.name = name;
        this.color = color;
    }    
}