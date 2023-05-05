
namespace Piramide{
    public static class Piramide {

        public static int Piani( int mattoni )
        {
            double lev = 0;
            int i = 0;
            int coda = i-2;
            if(mattoni==0){
                return 0;
            }
            while(){
                lev = mattoni% System.Math.Pow(i,2)+System.Math.Pow(coda,2);
                coda=coda-2;
            }
            return lev;
        }
        public static int Rimanenti( int mattoni )
        {
            return 0;
        }

    }
}