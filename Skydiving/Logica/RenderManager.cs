using System;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Skydiving.Logica {
    /// <summary>
    /// aanvaard variabelen die gebruikt zullen worden voor de fysische berekeningen (en dus doorgegeven worden aan de FysicaManager) 
    /// en produceert daarvoor een Bitmap afbeelding die dan in een pictureBox weergegeven kan worden voor grafische feedback.
    /// </summary>
    public class RenderManager {
        Bitmap drawPlane;
        Graphics planeGraphics;
        FysicaManager fm;

        int planeVirtualWidth, planeVirtualHeight;
        int planeWidth, planeHeight;
        float SchaalX, SchaalY;

        /// <summary>
        /// Deze constructor zal een object van de RenderManager klasse aanmaken. Er wordt gevraag om de echte afmetingen van de doel afbeelding, en de virtuele afmetingen die voorgesteld moeten worden
        /// </summary>
        /// <param name="planeHeight">De hoogte van de doel afbeelding</param>
        /// <param name="planeWidth">De breedte van de doel afbeelding</param>
        /// <param name="planeVirtualHeight">De hoogte van de content van de afbeelding</param>
        /// <param name="planeVirtualWidth">De breedte van de content van de afbeelding</param>
        public RenderManager(int planeHeight, int planeWidth, int planeVirtualHeight, int planeVirtualWidth) {
            InitRenderer(planeHeight, planeWidth, planeVirtualHeight, planeVirtualWidth);
            this.planeVirtualHeight = planeVirtualHeight;
            this.planeVirtualWidth = planeVirtualWidth;
            this.planeHeight = planeHeight;
            this.planeWidth = planeWidth;
        }

        /// <summary>
        /// Stel de hoogte en breedte waarden opnieuw in
        /// </summary>
        /// <param name="planeHeight">De hoogte van de doel afbeelding</param>
        /// <param name="planeWidth">De breedte van de doel afbeelding</param>
        /// <param name="planeVirtualHeight">De hoogte van de content van de afbeelding</param>
        /// <param name="planeVirtualWidth">De breedte van de content van de afbeelding</param>
        public void Reset(int planeHeight, int planeWidth, int planeVirtualHeight, int planeVirtualWidth) {
            InitRenderer(planeHeight, planeWidth, planeVirtualHeight, planeVirtualWidth);
            this.planeVirtualHeight = planeVirtualHeight;
            this.planeVirtualWidth = planeVirtualWidth;
            this.planeHeight = planeHeight;
            this.planeWidth = planeWidth;
        }

        /// <summary>
        /// Deze methode zal de fysische variabelen doorgeven aan de FysicaManager zodat de berekeningen uitgevoerd kunnen worden
        /// </summary>
        /// <param name="startHoogte">De starthoogte van het object</param>
        /// <param name="valversnelling">De heersende valversnelling</param>
        /// <param name="massadichtheidOmgevingsstof">De massadichtheid van de omgevingsstof</param>
        /// <param name="massa">De massa van het vallend object</param>
        /// <param name="Cw">De weerstandscoëficiënt van het object</param>
        /// <param name="oppervlakte">De oppervlakte van de dwarsdoorsnede van het object, loodrecht op de valrichting</param>
        public void InsertPhysicsValues(float startHoogte, double valversnelling, double massadichtheidOmgevingsstof, float massa, float Cw, double oppervlakte) {
            fm = new FysicaManager(startHoogte, valversnelling, massadichtheidOmgevingsstof, massa, Cw, oppervlakte);
        }

        /// <summary>
        /// Deze methode laat toe om de oppervlakte van de dwarsdoorsnede aan te passen
        /// </summary>
        /// <param name="opper">De nieuwe waarde</param>
        public void UpdateArea(double opper) {
            this.fm.Oppervlakte = opper;
        }

        /// <summary>
        /// Deze methode zal een array van toepasselijk waarden teruggeven die aan de gebruiker getoond kunnen worden als feedback
        /// </summary>
        /// <returns>Array van doubles. 0: Huidige versnelling; 1: Huidige snelheid; 2: Huidige hoogte; 3: Fw; 4:Fg</returns>
        public double[] GetValues() {
            Double[] val = new Double[5];
            val[0] = fm.Versnelling;
            val[1] = fm.Snelheid;
            val[2] = fm.Hoogte;
            val[3] = fm.FW;
            val[4] = fm.FG;
            return val;
        }

        /// <summary>
        /// Deze methode zal een nieuwe bitmap genereren a.d.h.v. een meegegeven Graphics object, in functie van een tijdsverloop
        /// </summary>
        /// <param name="tijdsverloop">De tijd, in seconden, de verlopen is sinds de laatste tekenoproep</param>
        /// <param name="output">het graphics component van de picturebox waarop getekend moet worden</param>
        /// <param name="parachute">True indien de parachute getekend moet worden, anders false</param>
        public void Render(float tijdsverloop, Graphics output, bool parachute) {
            // Update to fysische waarden
            fm.BerekenWaarden(tijdsverloop);

            // Maak een blauwe achtergrond
            planeGraphics.Clear(Color.AliceBlue);

            // Teken een laagje grond
            planeGraphics.FillRectangle(new SolidBrush(Color.ForestGreen), -planeVirtualWidth / 2, -30, planeVirtualWidth, 20);

            // Teken het vallend object
            planeGraphics.FillEllipse(new SolidBrush(Color.BlanchedAlmond), new Rectangle(new Point(-10, (int)fm.Hoogte -10), new Size((int)(20 / SchaalX), (int)(20 / SchaalY))));

            // Teken Fg vector
            planeGraphics.DrawLine(new Pen(Color.IndianRed), new Point(0, (int)fm.Hoogte), new Point(0, (int)(fm.Hoogte - SchaalY * fm.FG / 5)));
            planeGraphics.FillPolygon(new SolidBrush(Color.IndianRed), new Point[3] { new Point(5, (int)(fm.Hoogte - SchaalY * fm.FG / 5)), new Point(-5, (int)(fm.Hoogte - SchaalY * fm.FG / 5)), new Point(0, (int)(fm.Hoogte - SchaalY * fm.FG / 5) - 20) });
            planeGraphics.DrawString("Fg", new Font(FontFamily.GenericMonospace, 10), new SolidBrush(Color.IndianRed), new Point(0, (int)(fm.Hoogte - SchaalY * fm.FG / 5)));

            // Teken Fw vector
            planeGraphics.DrawLine(new Pen(Color.GreenYellow), new Point(0, (int)fm.Hoogte), new Point(0, (int)(fm.Hoogte + SchaalY * fm.FW / 5)));
            planeGraphics.FillPolygon(new SolidBrush(Color.GreenYellow), new Point[3] { new Point(5, (int)(fm.Hoogte + SchaalY * fm.FW / 5)), new Point(-5, (int)(fm.Hoogte + SchaalY * fm.FW / 5)), new Point(0, (int)(fm.Hoogte + SchaalY * fm.FW / 5) + 20) });
            planeGraphics.DrawString("Fw", new Font(FontFamily.GenericMonospace, 10), new SolidBrush(Color.IndianRed), new Point(0, (int)(fm.Hoogte + SchaalY * fm.FW / 5)));

            // Teken parachute indien van toepassing
            if (parachute) {
                planeGraphics.DrawLine(new Pen(Color.Black), new Point(0, (int)fm.Hoogte), new Point(10, (int)fm.Hoogte + 40));
                planeGraphics.DrawLine(new Pen(Color.Black), new Point(0, (int)fm.Hoogte), new Point(-10, (int)fm.Hoogte + 40));
                planeGraphics.DrawArc(new Pen(Color.Black), new Rectangle(-15, (int)fm.Hoogte + 22, 30, 20), 0,180);
            }

            // Teken hoogtelijn
            for (int i = 100; i < this.planeVirtualHeight; i+= 100) {
                planeGraphics.DrawLine(new Pen(Color.Black), new Point(-planeVirtualWidth/2,i), new Point(-planeVirtualWidth/2 + 40,i));
                TextRenderer.DrawText(planeGraphics,i + "m", new Font(FontFamily.GenericSansSerif, 12), new Point(0,planeHeight - 35 - (int)(i *SchaalY)), Color.Black);
            }

            // Teken dit alles op de display
            output.DrawImage(drawPlane, new Rectangle(0, 0, planeWidth, planeHeight), new Rectangle(0, 0, planeWidth, planeHeight), GraphicsUnit.Pixel);
        }

        /// <summary>
        /// Deze methode zal alles in gereedheid brengen om het bewerken van de bitmap zo vlot mogelijk te laten gebeuren
        /// </summary>
        /// <param name="planeHeight">De hoogte van de doel afbeelding</param>
        /// <param name="planeWidth">De breedte van de doel afbeelding</param>
        /// <param name="planeVirtualHeight">De hoogte van de content van de afbeelding</param>
        /// <param name="planeVirtualWidth">De breedte van de content van de afbeelding</param>
        private void InitRenderer(int planeHeight, int planeWidth, int planeVirtualHeight, int planeVirtualWidth) {
            drawPlane = new Bitmap(planeWidth, planeHeight);
            planeGraphics = Graphics.FromImage(drawPlane);

            // transformatie voor display met oorsprong in midden, breedte en hoogte meegegeven, rechtshandig assenstelsel
            SchaalX = planeWidth * 1.0f / planeVirtualWidth;
            SchaalY = planeHeight * 1.0f / planeVirtualHeight;

            planeGraphics.ResetTransform();
            planeGraphics.ScaleTransform(SchaalX, -SchaalY); //schaling
            planeGraphics.TranslateTransform(planeWidth / (2f * SchaalX) , (-planeHeight / SchaalY) + 30); // oorsprong 30px boven onderkant, en in het midden (grond = 30px hoog)
        }
    }
}
