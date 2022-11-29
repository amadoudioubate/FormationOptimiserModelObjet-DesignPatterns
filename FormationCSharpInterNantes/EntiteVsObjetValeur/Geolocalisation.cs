namespace FormationCSharpInterNantes.EntiteVsObjetValeur
{
    // ValueObject : Object immutable (renseigné à la création), valeur ne bouge pas
    // IComprable est générique pour que je puisse comparé n'importe kel type objet, sans connaitre le type à l'avance
    public class Geolocalisation : IComparable<Geolocalisation> 
    {
        private double _latitude;
        private double _longitude;

        public Geolocalisation(double latitude, double longitude)
        {
            _latitude = latitude;
            _longitude = longitude;
        }   

        public override bool Equals(object? obj)
        {
            return obj is Geolocalisation geolocalisation &&
                   _latitude == geolocalisation._latitude &&
                   _longitude == geolocalisation._longitude;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_latitude, _longitude);
        }

        public override string? ToString()
        {
            return $"{_longitude}, {_latitude}";
        }

        public int CompareTo(Geolocalisation? other)
        {
            // Comparaison basée par distance
            double rayonTerre = 6372; // en km

            double dLat = EnRadians(other._latitude - _latitude);
            double dLon = EnRadians(other._longitude - _longitude);

            double sindLat = Math.Asin(dLat / 2);
            double sindLon = Math.Asin(dLon / 2);

            double a = Math.Pow(sindLat, 2) + Math.Pow(sindLon, 2) * Math.Cos(EnRadians(_latitude)) * Math.Cos(EnRadians(_longitude));

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            double dist = rayonTerre * c;

            return Convert.ToInt32(dist);
        }

        private static double EnRadians(double angle) => angle * Math.PI / 180;
        
        
    }
}