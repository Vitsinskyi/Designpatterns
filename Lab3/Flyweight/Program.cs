using System.Text;
using Composite;
namespace Flyweight;

class Program
{
    static void Main(string[] args)
    {
        long startMemory = GC.GetTotalMemory(true);
        
        string text = "THE TRAGEDY OF ROMEO AND JULIET\n\nby William Shakespeare\n\n\n\n\nContents\n\nTHE PROLOGUE.\n\nACT I\nScene I. A public place.\nScene II. A Street.\nScene III. Room in Capulet’s House.\nScene IV. A Street.\nScene V. A Hall in Capulet’s House.\n\nACT II\nCHORUS.\nScene I. An open place adjoining Capulet’s Garden.\nScene II. Capulet’s Garden.\nScene III. Friar Lawrence’s Cell.\nScene IV. A Street.\nScene V. Capulet’s Garden.\nScene VI. Friar Lawrence’s Cell.\n\nACT III\nScene I. A public Place.\nScene II. A Room in Capulet’s House.\nScene III. Friar Lawrence’s cell.\nScene IV. A Room in Capulet’s House.\nScene V. An open Gallery to Juliet’s Chamber, overlooking the Garden.\n\nACT IV\nScene I. Friar Lawrence’s Cell.\nScene II. Hall in Capulet’s House.\nScene III. Juliet’s Chamber.\nScene IV. Hall in Capulet’s House.\nScene V. Juliet’s Chamber; Juliet on the bed.\n\nACT V\nScene I. Mantua. A Street.\nScene II. Friar Lawrence’s Cell.\nScene III. A churchyard; in it a Monument belonging to the Capulets.\n\n\n\n\n Dramatis Personæ\n\nESCALUS, Prince of Verona.\nMERCUTIO, kinsman to the Prince, and friend to Romeo.\nPARIS, a young Nobleman, kinsman to the Prince.\nPage to Paris.\n\nMONTAGUE, head of a Veronese family at feud with the Capulets.\nLADY MONTAGUE, wife to Montague.\nROMEO, son to Montague.\nBENVOLIO, nephew to Montague, and friend to Romeo.\nABRAM, servant to Montague.\nBALTHASAR, servant to Romeo.\n\nCAPULET, head of a Veronese family at feud with the Montagues.\nLADY CAPULET, wife to Capulet.\nJULIET, daughter to Capulet.\nTYBALT, nephew to Lady Capulet.\nCAPULET’S COUSIN, an old man.\nNURSE to Juliet.\nPETER, servant to Juliet’s Nurse.\nSAMPSON, servant to Capulet.\nGREGORY, servant to Capulet.\nServants.\n\nFRIAR LAWRENCE, a Franciscan.\nFRIAR JOHN, of the same Order.\nAn Apothecary.\nCHORUS.\nThree Musicians.\nAn Officer.\nCitizens of Verona; several Men and Women, relations to both houses;\nMaskers, Guards, Watchmen and Attendants.\n\nSCENE. During the greater part of the Play in Verona; once, in the\nFifth Act, at Mantua.\n\n\n\n\nTHE PROLOGUE\n\n\n Enter Chorus.\n\nCHORUS.\nTwo households, both alike in dignity,\nIn fair Verona, where we lay our scene,\nFrom ancient grudge break to new mutiny,\nWhere civil blood makes civil hands unclean.\nFrom forth the fatal loins of these two foes\nA pair of star-cross’d lovers take their life;\nWhose misadventur’d piteous overthrows\nDoth with their death bury their parents’ strife.\nThe fearful passage of their death-mark’d love,\nAnd the continuance of their parents’ rage,\nWhich, but their children’s end, nought could remove,\nIs now the two hours’ traffic of our stage;\nThe which, if you with patient ears attend,\nWhat here shall miss, our toil shall strive to mend.\n\n [_Exit._]\n";
        string[] lines = text.Split('\n');

        LightElementNode root = new LightElementNode("div", true, false);

        // Flyweight pattern: reuse the same text node for spaces
        //LightTextNode spaceNode = new LightTextNode(" ");

        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            LightElementNode node;

            if (i == 0)
            {
                node = new LightElementNode("h1", false, false);
            }
            else if (line.StartsWith(" "))
            {
                node = new LightElementNode("blockquote", false, false);
                //node.AddChild(spaceNode);  // use the flyweight space node
            }
            else if (line.Length < 20)
            {
                node = new LightElementNode("h2", false, false);
            }
            else
            {
                node = new LightElementNode("p", false, false);
            }

            node.AddChild(new LightTextNode(line.Trim()));
            root.AddChild(node);
        }

        Console.WriteLine(root.OuterHtml);
        
        long endMemory = GC.GetTotalMemory(true);
        long usedMemory = endMemory - startMemory;
        Console.WriteLine($"Використано пам'яті: {usedMemory} байт");
    }
}