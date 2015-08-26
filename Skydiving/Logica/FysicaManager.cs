using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skydiving.Logica {
    class FysicaManager {
        // Externe - vaste - waarden
        readonly float startHoogte;
        readonly float massa;
        readonly float Cw;
        double oppervlakte;
        readonly double massadichtheidOmgevingsstof;

        // interne waarden
        readonly double Fg;
        double Fw = 0;        
        float snelheid = 0;
        float hoogte;

        public FysicaManager(float startHoogte, double valversnelling, double massadichtheidOmgevingsstof, float massa, float Cw, double oppervlakte) {
            // Omgeving
            this.startHoogte = startHoogte;
            this.massadichtheidOmgevingsstof = massadichtheidOmgevingsstof;
            this.Fg = FysicaManager.BerekenFg(valversnelling, massa);

            // Object
            this.Cw = Cw;
            this.massa = massa;            
            this.oppervlakte = oppervlakte;
            this.hoogte = startHoogte;
        }

        public double Oppervlakte {
            set { this.oppervlakte = value; }
        }

        public double FG {
            get { return Fg; }
        }

        public double FW {
            get { return Fw; }
        }

        public float Snelheid {
            get { return snelheid; }
        }

        public float Hoogte {
            get { return hoogte; }
        }

        public double Versnelling {
            get { return FysicaManager.BerekenVersnelling(this.Fg, this.Fw, this.massa); }
        }

        /// <summary>
        /// Deze methode zal alle waarden bijwerken a.d.h.v. een meegegeven gepasseerd aantal seconden
        /// </summary>
        /// <param name="tijdsverloop">Het aantal milliseconden dat voorbij gegaan is sinds de laatste berekening</param>
        public void BerekenWaarden(float tijdsverloop) {
            this.Fw = FysicaManager.BerekenFw(this.massadichtheidOmgevingsstof, this.snelheid, this.oppervlakte, this.Cw);
            this.snelheid += (float)(tijdsverloop * FysicaManager.BerekenVersnelling(this.Fg, this.Fw, this.massa));
            this.hoogte -= snelheid * tijdsverloop;
            if (this.hoogte < 0) {
                this.hoogte = 0;
                this.Fw = this.Fg;
                this.snelheid = 0;
            }
        }

        #region private methodes

        /// <summary>
        /// Deze methode zal de versnelling berekenen die een object beinvloed voor bepaalde krachten ondergaat
        /// </summary>
        /// <param name="Fg">De zwaartekracht</param>
        /// <param name="Fw">De wrijvingskracht</param>
        /// <param name="massa">De massa van het object</param>
        /// <returns>De versnelling van het object bij gegeven inwerkende krachten</returns>
        private static double BerekenVersnelling(double Fg, double Fw, float massa) {
            return (Fg - Fw) / massa;
        }

        /// <summary>
        /// Deze methode zal de wrijvingskracht berekenen die een vallend object ondervind
        /// </summary>
        /// <param name="massadichtheidOmgevingsstof">De massadichtheid van de omgevingsstof</param>
        /// <param name="snelheid">De snelheid waaraan het object aan het vallen is</param>
        /// <param name="oppervlake">De oppervlakte van de dwarsdoorsnede van het object, loodrecht op de valrichting</param>
        /// <param name="Cw">De weerstandscoëfficiënt van het object</param>
        /// <returns>Fw</returns>
        private static double BerekenFw(double massadichtheidOmgevingsstof, float snelheid, double oppervlake, float Cw) {
            return 0.5 * massadichtheidOmgevingsstof * Math.Pow(snelheid, 2) * oppervlake * Cw;
        }

        /// <summary>
        /// Deze methode zal de zwaartekracht berekenen die een object ondergaat.
        /// </summary>
        /// <param name="valversnelling">De heersende valversnelling</param>
        /// <param name="massa">De massa van het object</param>
        /// <returns>Fg</returns>
        private static double BerekenFg(double valversnelling, float massa) {
            return valversnelling * massa;
        }

        #endregion
    }
}
