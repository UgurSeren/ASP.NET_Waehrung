namespace WebEntwicklung.Models
{
    public static class ZSK
    {
        
        public static int k { set; get; } 
        public static int z { set; get;}
        public static int s { set; get; }
        public static int kz { set; get; }
        public static int rest { set; get; }

        public static void Umwandlung(Betrag b)
        {
            
            
                
                
                    k = b.betrag / 2800;
                    rest = b.betrag % 2800;
                
                
                    s = rest / 650;
                    rest = rest % 650;
                
                
                
                    z=rest/500;
                    rest = rest % 500;

                
                
                    kz = kz / 50;
                    rest = rest % 50;
                    
                
                

            
        }
    }
}
