//program creates an undirected weighted graph, adds stations,
//establishes connections between them using AddTwoWayEdge,
//and then runs the Dijkstra algorithm to find the shortest path between the given source and target stations
namespace UndirectedWeightedGraph
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            //create an instance of the Graph class
            Graph graph = new Graph();

            //add Station instances to it using the CreateStation method
            //These stations represent the nodes of the graph
            Station Aldgate_Metro = graph.CreateStation("Aldgate (Metro)", Enum.StationAccess.Stairs, true);
            Station Aldgate_Circle = graph.CreateStation("Aldgate (Circle)", Enum.StationAccess.Stairs, true);

            Station AldgateEast_District = graph.CreateStation("AldgateEast (District)", Enum.StationAccess.Stairs, true);
            Station AldgateEast_Ham = graph.CreateStation("AldgateEast (Ham)", Enum.StationAccess.Stairs, true);

            Station Angel = graph.CreateStation("Angel", Enum.StationAccess.Stairs, true);

            Station BakerStreet_Bakerloo = graph.CreateStation("BakerStreet (Bakerloo)", Enum.StationAccess.Stairs, true);
            Station BakerStreet_Ham = graph.CreateStation("BakerStreet (Ham)", Enum.StationAccess.Stairs, true);
            Station BakerStreet_Circle = graph.CreateStation("BakerStreet (Circle)", Enum.StationAccess.Stairs, true);
            Station BakerStreet_Metro = graph.CreateStation("BakerStreet (Metro)", Enum.StationAccess.Stairs, true);
            Station BakerStreet_Jubilee = graph.CreateStation("BakerStreet (Jubilee)", Enum.StationAccess.Stairs, true);

            Station Bank_Central = graph.CreateStation("Bank (Central)", Enum.StationAccess.Stairs, true);
            Station Bank_WaterlooAndCity = graph.CreateStation("Bank (Waterloo and City)", Enum.StationAccess.Stairs, true);

            Station Barbican_Ham = graph.CreateStation("Barbican (Ham)", Enum.StationAccess.Stairs, true);
            Station Barbican_Circle = graph.CreateStation("Barbican (Circle)", Enum.StationAccess.Stairs, true);
            Station Barbican_Metro = graph.CreateStation("Barbican (Metro)", Enum.StationAccess.Stairs, true);

            Station Bayswater_Circle = graph.CreateStation("Bayswater (Circle)", Enum.StationAccess.Stairs, true);
            Station Bayswater_District = graph.CreateStation("Bayswater (District)", Enum.StationAccess.Stairs, true);

            Station Blackfriars_Circle = graph.CreateStation("Blackfriars (Circle)", Enum.StationAccess.Stairs, true);
            Station Blackfriars_District = graph.CreateStation("Blackfriars (District)", Enum.StationAccess.Stairs, true);

            Station BondStreet_Central = graph.CreateStation("BondStreet (Central)", Enum.StationAccess.Stairs, true);
            Station BondStreet_Jubilee = graph.CreateStation("BondStreet (Jubilee)", Enum.StationAccess.Stairs, true);

            Station Borough = graph.CreateStation("Borough", Enum.StationAccess.Stairs, true);

            Station CannonStreet_Circle = graph.CreateStation("CannonStreet (Circle)", Enum.StationAccess.Stairs, true);
            Station CannonStreet_District = graph.CreateStation("CannonStreet (District)", Enum.StationAccess.Stairs, true);

            Station ChanceryLane = graph.CreateStation("ChanceryLane", Enum.StationAccess.Stairs, true);

            Station CharingCross_Bakerloo = graph.CreateStation("CharringCross (Bakerloo", Enum.StationAccess.Stairs, true);
            Station CharingCross_Northern = graph.CreateStation("CharringCross (Northern)", Enum.StationAccess.Stairs, true);

            Station CoventGarden = graph.CreateStation("CoventGarden", Enum.StationAccess.Stairs, true);
            Station EarlsCourt = graph.CreateStation("EarlsCourt", Enum.StationAccess.Stairs, true);

            Station EdgwareRoad_Circle = graph.CreateStation("EdgwareRoad (Circle)", Enum.StationAccess.Stairs, true);
            Station EdgwareRoad_District = graph.CreateStation("EdgwareRoad (District)", Enum.StationAccess.Stairs, true);
            Station EdgwareRoad_Bakerloo = graph.CreateStation("EdgwareRoad (Bakerloo)", Enum.StationAccess.Stairs, true);
            Station EdgwareRoad_Ham = graph.CreateStation("EdgwareRoad (Ham)", Enum.StationAccess.Stairs, true);

            Station ElephantandCastle_Bakerloo = graph.CreateStation("ElephantandCastle (Bakerloo)", Enum.StationAccess.Stairs, true);
            Station ElephantandCastle_Northern = graph.CreateStation("ElephantandCastle (Northern)", Enum.StationAccess.Stairs, true);

            Station Embankment_Bakerloo = graph.CreateStation("Embarkment (Bakerloo)", Enum.StationAccess.Stairs, true);
            Station Embankment_Northern = graph.CreateStation("Embarkment (Northern)", Enum.StationAccess.Stairs, true);
            Station Embankment_Circle = graph.CreateStation("Embarkment (Circle)", Enum.StationAccess.Stairs, true);
            Station Embankment_District = graph.CreateStation("Embarkment (District)", Enum.StationAccess.Stairs, true);

            Station Euston_Northern = graph.CreateStation("Euston (Northern)", Enum.StationAccess.Stairs, true);
            Station Euston_Victoria = graph.CreateStation("Euston (Victoria)", Enum.StationAccess.Stairs, true);

            Station EustonSquare_Ham = graph.CreateStation("EustonSquare (Ham)", Enum.StationAccess.Stairs, true);
            Station EustonSquare_Circle = graph.CreateStation("EustonSquare (Circle)", Enum.StationAccess.Stairs, true);
            Station EustonSquare_Metro = graph.CreateStation("EustonSquare (Metro)", Enum.StationAccess.Stairs, true);

            Station Farringdon_Ham = graph.CreateStation("Farringdon (Ham)", Enum.StationAccess.Stairs, true);
            Station Farringdon_Circle = graph.CreateStation("Farringdon (Circle)", Enum.StationAccess.Stairs, true);
            Station Farringdon_Metro = graph.CreateStation("Farringdon (Metro)", Enum.StationAccess.Stairs, true);

            Station GloucesterRoad_Circle = graph.CreateStation("GloucesterRoad (Circle)", Enum.StationAccess.Stairs, true);
            Station GloucesterRoad_District = graph.CreateStation("GloucesterRoad (District)", Enum.StationAccess.Stairs, true);
            Station GloucesterRoad_Piccadilly = graph.CreateStation("GloucesterRoad (Piccasilly)", Enum.StationAccess.Stairs, true);

            Station GoodgeStreet = graph.CreateStation("GoodgeStreet", Enum.StationAccess.Stairs, true);

            Station GreatPortlandStreet_Ham = graph.CreateStation("GreatPortlandStreet (Ham)", Enum.StationAccess.Stairs, true);
            Station GreatPortlandStreet_Circle = graph.CreateStation("GreatPortlandStreet (Circle)", Enum.StationAccess.Stairs, true);
            Station GreatPortlandStreet_Metro = graph.CreateStation("GreatPortlandStreet (Metro)", Enum.StationAccess.Stairs, true);

            Station GreenPark_Jubilee = graph.CreateStation("GreenPark (Jubilee)", Enum.StationAccess.Stairs, true);
            Station GreenPark_Piccadilly = graph.CreateStation("GreenPark (Piccadilly)", Enum.StationAccess.Stairs, true);
            Station GreenPark_Victoria = graph.CreateStation("GreenPark (Victoria)", Enum.StationAccess.Stairs, true);

            Station HighStreetKensington_Circle = graph.CreateStation("HighStreetKensington (Circle)", Enum.StationAccess.Stairs, true);
            Station HighStreetKensington_District = graph.CreateStation("HighStreetKensington (District)", Enum.StationAccess.Stairs, true);

            Station Holborn_Central = graph.CreateStation("Holborn (Central)", Enum.StationAccess.Stairs, true);
            Station Holborn_Piccadilly = graph.CreateStation("Holborn (Piccadilly)", Enum.StationAccess.Stairs, true);

            Station HydeParkCorner = graph.CreateStation("HydeParkCorner", Enum.StationAccess.Stairs, true);

            Station KingsCrossStPancras_Ham = graph.CreateStation("KingsCrossStPancras (Ham)", Enum.StationAccess.Stairs, true);
            Station KingsCrossStPancras_Circle = graph.CreateStation("KingsCrossStPancras (Circle)", Enum.StationAccess.Stairs, true);
            Station KingsCrossStPancras_Metro = graph.CreateStation("KingsCrossStPancras (Metro)", Enum.StationAccess.Stairs, true);
            Station KingsCrossStPancras_Northern = graph.CreateStation("KingsCrossStPancras (Northern)", Enum.StationAccess.Stairs, true);
            Station KingsCrossStPancras_Victoria = graph.CreateStation("KingsCrossStPancras (Victoria)", Enum.StationAccess.Stairs, true);
            Station KingsCrossStPancras_Piccadilly = graph.CreateStation("KingsCrossStPancras (Piccadilly)", Enum.StationAccess.Stairs, true);

            Station Knightsbridge = graph.CreateStation("Knightsbridge", Enum.StationAccess.Stairs, true);
            Station LambethNorth = graph.CreateStation("LambethNorth", Enum.StationAccess.Stairs, true);
            Station LancasterGate = graph.CreateStation("LancasterGate", Enum.StationAccess.Stairs, true);

            Station LeicesterSquare_Northern = graph.CreateStation("LeicesterSquare (Northern)", Enum.StationAccess.Stairs, true);
            Station LeicesterSquare_Piccadilly = graph.CreateStation("LeicesterSquare (Piccadilly)", Enum.StationAccess.Stairs, true);

            Station LiverpoolStreet_Central = graph.CreateStation("LiverpoolStreet (Central)", Enum.StationAccess.Stairs, true);
            Station LiverpoolStreet_Circle = graph.CreateStation("LiverpoolStreet (Circle)", Enum.StationAccess.Stairs, true);
            Station LiverpoolStreet_Ham = graph.CreateStation("LiverpoolStreet (Ham)", Enum.StationAccess.Stairs, true);
            Station LiverpoolStreet_Metro = graph.CreateStation("LiverpoolStreet (Metro)", Enum.StationAccess.Stairs, true);

            Station LondonBridge_Jubilee = graph.CreateStation("LondonBridge (Jubille)", Enum.StationAccess.Stairs, true);
            Station LondonBridge_Northern = graph.CreateStation("LondonBridge (Northern)", Enum.StationAccess.Stairs, true);

            Station MansionHouse_Circle = graph.CreateStation("MansionHouse (Circle)", Enum.StationAccess.Stairs, true);
            Station MansionHouse_District = graph.CreateStation("MansionHouse (District)", Enum.StationAccess.Stairs, true);

            Station MarbleArch = graph.CreateStation("MarbleArch (Central)", Enum.StationAccess.Stairs, true);
            Station Marylebone = graph.CreateStation("Marylebone", Enum.StationAccess.Stairs, true);

            Station Monument_Circle = graph.CreateStation("Monument (Circle)", Enum.StationAccess.Stairs, true);
            Station Monument_District = graph.CreateStation("Monument (District)", Enum.StationAccess.Stairs, true);
            Station Monument_Northern = graph.CreateStation("Monument (Northern)", Enum.StationAccess.Stairs, true);


            Station Moorgate_Ham = graph.CreateStation("Moorgate (Ham)", Enum.StationAccess.Stairs, true);
            Station Moorgate_Circle = graph.CreateStation("Moorgate (Circle)", Enum.StationAccess.Stairs, true);
            Station Moorgate_Metro = graph.CreateStation("Moorgate (Metro)", Enum.StationAccess.Stairs, true);
            Station Moorgate_Northern = graph.CreateStation("Moorgate (Northern)", Enum.StationAccess.Stairs, true);


            Station NottinghillGate_Central = graph.CreateStation("NottinghillGate (Central)", Enum.StationAccess.Stairs, true);
            Station NottinghillGate_Circle = graph.CreateStation("NottinghillGate (Circle)", Enum.StationAccess.Stairs, true);
            Station NottinghillGate_District = graph.CreateStation("NottinghillGate (District)", Enum.StationAccess.Stairs, true);

            Station OldStreet = graph.CreateStation("OldStreet", Enum.StationAccess.Stairs, true);

            Station OxfordCircus_Bakerloo = graph.CreateStation("OxfordCircus (Bakerloo)", Enum.StationAccess.Stairs, true);
            Station OxfordCircus_Central = graph.CreateStation("OxfordCircus (Central)", Enum.StationAccess.Stairs, true);
            Station OxfordCircus_Victoria = graph.CreateStation("OxfordCircus (Victoria)", Enum.StationAccess.Stairs, true);

            Station Paddington_Bakerloo = graph.CreateStation("Paddington (Bakerloo)", Enum.StationAccess.Stairs, true);
            Station Paddington_Circle = graph.CreateStation("Paddington (Circle)", Enum.StationAccess.Stairs, true);
            Station Paddington_District = graph.CreateStation("Paddington (District)", Enum.StationAccess.Stairs, true);
            Station Paddington_Ham = graph.CreateStation("Paddington (Ham)", Enum.StationAccess.Stairs, true);


            Station Picadillycircus_Bakerloo = graph.CreateStation("Picadillycircus (Bakerloo)", Enum.StationAccess.Stairs, true);
            Station Picadillycircus_Piccadilly = graph.CreateStation("Picadillycircus (PIccadilly)", Enum.StationAccess.Stairs, true);

            Station Pimlico = graph.CreateStation("Pimlico", Enum.StationAccess.Stairs, true);
            Station Queensway = graph.CreateStation("Queensway", Enum.StationAccess.Stairs, true);
            Station RegentsPark = graph.CreateStation("RegentsPark", Enum.StationAccess.Stairs, true);
            Station RussellSquare = graph.CreateStation("RussellSquare", Enum.StationAccess.Stairs, true);

            Station SloaneSquare_Circle = graph.CreateStation("SloaneSquare (Circle)", Enum.StationAccess.Stairs, true);
            Station SloaneSquare_District = graph.CreateStation("SloaneSquare (District)", Enum.StationAccess.Stairs, true);

            Station SouthKensington_Circle = graph.CreateStation("SouthKensington (Circle)", Enum.StationAccess.Stairs, true);
            Station SouthKensington_District = graph.CreateStation("SouthKensington (District)", Enum.StationAccess.Stairs, true);
            Station SouthKensington_Piccadilly = graph.CreateStation("SouthKensington (Piccadilly)", Enum.StationAccess.Stairs, true);


            Station Southwark = graph.CreateStation("Southwark", Enum.StationAccess.Stairs, true);

            Station StJamessPark_Circle = graph.CreateStation("StJamessPark (Circle)", Enum.StationAccess.Stairs, true);
            Station StJamessPark_District = graph.CreateStation("StJamessPark (District)", Enum.StationAccess.Stairs, true);

            Station StPauls = graph.CreateStation("StPauls", Enum.StationAccess.Stairs, true);

            Station Temple_Circle = graph.CreateStation("Temple (Circle)", Enum.StationAccess.Stairs, true);
            Station Temple_District = graph.CreateStation("Temple (District)", Enum.StationAccess.Stairs, true);

            Station TottenhamCourtRoad_Central = graph.CreateStation("TottenhamCourtRoad (Central)", Enum.StationAccess.Stairs, true);
            Station TottenhamCourtRoad_Northern = graph.CreateStation("TottenhamCourtRoad (Northern)", Enum.StationAccess.Stairs, true);

            Station TowerHill_Circle = graph.CreateStation("TowerHill (Circle)", Enum.StationAccess.Stairs, true);
            Station TowerHill_District = graph.CreateStation("TowerHill (District)", Enum.StationAccess.Stairs, true);

            Station Vauxhall = graph.CreateStation("Vauxhall", Enum.StationAccess.Stairs, true);

            Station Victoria_Circle = graph.CreateStation("Victoria (Circle)", Enum.StationAccess.Stairs, true);
            Station Victoria_District = graph.CreateStation("Victoria (District)", Enum.StationAccess.Stairs, true);
            Station Victoria_Victoria = graph.CreateStation("Victoria (Victoria)", Enum.StationAccess.Stairs, true);

            Station WarrenStreet_Northern = graph.CreateStation("WarrenStreet (Northern)", Enum.StationAccess.Stairs, true);
            Station WarrenStreet_Victoria = graph.CreateStation("WarrenStreet (Victoria)", Enum.StationAccess.Stairs, true);

            Station Waterloo_Bakerloo = graph.CreateStation("Waterloo (Bakerloo)", Enum.StationAccess.Stairs, true);
            Station Waterloo_Northern = graph.CreateStation("Waterloo (Northern)", Enum.StationAccess.Stairs, true);
            Station Waterloo_Jubilee = graph.CreateStation("Waterloo (Jubilee)", Enum.StationAccess.Stairs, true);
            Station Waterloo_WaterlooAndCity = graph.CreateStation("Waterloo (Waterloo and City)", Enum.StationAccess.Stairs, true);

            Station Westminster_Circle = graph.CreateStation("Westminster (Circle)", Enum.StationAccess.Stairs, true);
            Station Westminster_District = graph.CreateStation("Westminster (District)", Enum.StationAccess.Stairs, true);
            Station Westminster_Jubilee = graph.CreateStation("Westminster (Jubilee)", Enum.StationAccess.Stairs, true);

            //connect pairs of stations by adding edges between them using the AddTwoWayEdge method
            //This creates an undirected weighted graph

            //BAKERLOO
            Paddington_Bakerloo.AddTwoWayEdge(EdgwareRoad_Bakerloo, 11);
            Paddington_Bakerloo.AddTwoWayEdge(Paddington_Circle, 0);
            Paddington_Bakerloo.AddTwoWayEdge(Paddington_District, 0);
            Paddington_Bakerloo.AddTwoWayEdge(Paddington_Ham, 0);
            EdgwareRoad_Bakerloo.AddTwoWayEdge(Marylebone, 7);
            Marylebone.AddTwoWayEdge(BakerStreet_Bakerloo, 6);
            BakerStreet_Bakerloo.AddTwoWayEdge(RegentsPark, 10);
            BakerStreet_Bakerloo.AddTwoWayEdge(BakerStreet_Circle, 0);
            BakerStreet_Bakerloo.AddTwoWayEdge(BakerStreet_Ham, 0);
            BakerStreet_Bakerloo.AddTwoWayEdge(BakerStreet_Jubilee, 0);
            BakerStreet_Bakerloo.AddTwoWayEdge(BakerStreet_Metro, 0);
            RegentsPark.AddTwoWayEdge(OxfordCircus_Bakerloo, 15);
            OxfordCircus_Bakerloo.AddTwoWayEdge(Picadillycircus_Bakerloo, 12);
            OxfordCircus_Bakerloo.AddTwoWayEdge(OxfordCircus_Central, 0);
            OxfordCircus_Bakerloo.AddTwoWayEdge(OxfordCircus_Victoria, 0);
            Picadillycircus_Bakerloo.AddTwoWayEdge(CharingCross_Bakerloo, 11);
            Picadillycircus_Bakerloo.AddTwoWayEdge(Picadillycircus_Piccadilly, 0);
            CharingCross_Bakerloo.AddTwoWayEdge(Embankment_Bakerloo, 3);
            CharingCross_Bakerloo.AddTwoWayEdge(CharingCross_Northern, 0);
            Embankment_Bakerloo.AddTwoWayEdge(Waterloo_Bakerloo, 6);
            Embankment_Bakerloo.AddTwoWayEdge(Embankment_Circle, 0);
            Embankment_Bakerloo.AddTwoWayEdge(Embankment_District, 0);
            Embankment_Bakerloo.AddTwoWayEdge(Embankment_Northern, 0);
            Waterloo_Bakerloo.AddTwoWayEdge(LambethNorth, 9);
            Waterloo_Bakerloo.AddTwoWayEdge(Waterloo_Jubilee, 0);
            Waterloo_Bakerloo.AddTwoWayEdge(Waterloo_Northern, 0);
            Waterloo_Bakerloo.AddTwoWayEdge(Waterloo_WaterlooAndCity, 0);
            LambethNorth.AddTwoWayEdge(ElephantandCastle_Bakerloo, 18);
            ElephantandCastle_Bakerloo.AddTwoWayEdge(ElephantandCastle_Northern, 0);

            //CENTRAL LINE
            NottinghillGate_Central.AddTwoWayEdge(Queensway, 8);
            NottinghillGate_Central.AddTwoWayEdge(NottinghillGate_Circle, 0);
            NottinghillGate_Central.AddTwoWayEdge(NottinghillGate_District, 0);
            Queensway.AddTwoWayEdge(LancasterGate, 10);
            LancasterGate.AddTwoWayEdge(MarbleArch, 15);
            MarbleArch.AddTwoWayEdge(BondStreet_Central, 7);
            BondStreet_Central.AddTwoWayEdge(OxfordCircus_Central, 7);
            BondStreet_Central.AddTwoWayEdge(BondStreet_Jubilee, 0);
            OxfordCircus_Central.AddTwoWayEdge(TottenhamCourtRoad_Central, 9);
            TottenhamCourtRoad_Central.AddTwoWayEdge(Holborn_Central, 10);
            TottenhamCourtRoad_Central.AddTwoWayEdge(TottenhamCourtRoad_Northern, 0);
            Holborn_Central.AddTwoWayEdge(ChanceryLane, 8);
            Holborn_Central.AddTwoWayEdge(Holborn_Piccadilly, 0);
            ChanceryLane.AddTwoWayEdge(StPauls, 14);
            StPauls.AddTwoWayEdge(Bank_Central, 9);
            Bank_Central.AddTwoWayEdge(LiverpoolStreet_Central, 10);
            Bank_Central.AddTwoWayEdge(Bank_WaterlooAndCity, 0);

            //CIRCLE LINE
            EdgwareRoad_Circle.AddTwoWayEdge(Paddington_Circle, 10);
            EdgwareRoad_Circle.AddTwoWayEdge(EdgwareRoad_District, 0);
            EdgwareRoad_Circle.AddTwoWayEdge(EdgwareRoad_Ham, 0);
            Paddington_Circle.AddTwoWayEdge(Bayswater_Circle, 17);
            Bayswater_Circle.AddTwoWayEdge(NottinghillGate_Circle, 10);
            Bayswater_Circle.AddTwoWayEdge(Bayswater_District, 0);
            NottinghillGate_Circle.AddTwoWayEdge(HighStreetKensington_Circle, 13);
            NottinghillGate_Circle.AddTwoWayEdge(NottinghillGate_District, 0);
            NottinghillGate_Circle.AddTwoWayEdge(NottinghillGate_Central, 0);
            HighStreetKensington_Circle.AddTwoWayEdge(GloucesterRoad_Circle, 18);
            HighStreetKensington_Circle.AddTwoWayEdge(HighStreetKensington_District, 0);
            GloucesterRoad_Circle.AddTwoWayEdge(SouthKensington_Circle, 8);
            GloucesterRoad_Circle.AddTwoWayEdge(GloucesterRoad_District, 0);
            GloucesterRoad_Circle.AddTwoWayEdge(GloucesterRoad_Piccadilly, 0);
            SouthKensington_Circle.AddTwoWayEdge(SloaneSquare_Circle, 17);
            SouthKensington_Circle.AddTwoWayEdge(SouthKensington_District, 0);
            SouthKensington_Circle.AddTwoWayEdge(SouthKensington_Piccadilly, 0);
            SloaneSquare_Circle.AddTwoWayEdge(Victoria_Circle, 13);
            SloaneSquare_Circle.AddTwoWayEdge(SloaneSquare_District, 0);
            Victoria_Circle.AddTwoWayEdge(StJamessPark_Circle, 11);
            Victoria_Circle.AddTwoWayEdge(Victoria_District, 0);
            Victoria_Circle.AddTwoWayEdge(Victoria_Victoria, 0);
            StJamessPark_Circle.AddTwoWayEdge(Westminster_Circle, 11);
            StJamessPark_Circle.AddTwoWayEdge(StJamessPark_District, 0);
            Westminster_Circle.AddTwoWayEdge(Embankment_Circle, 10);
            Westminster_Circle.AddTwoWayEdge(Westminster_Jubilee, 0);
            Westminster_Circle.AddTwoWayEdge(Westminster_District, 0);
            Embankment_Circle.AddTwoWayEdge(Temple_Circle, 9);
            Embankment_Circle.AddTwoWayEdge(Embankment_District, 0);
            Embankment_Circle.AddTwoWayEdge(Embankment_Northern, 0);
            Temple_Circle.AddTwoWayEdge(Blackfriars_Circle, 10);
            Temple_Circle.AddTwoWayEdge(Temple_District, 0);
            Blackfriars_Circle.AddTwoWayEdge(MansionHouse_Circle, 10);
            Blackfriars_Circle.AddTwoWayEdge(Blackfriars_District, 0);
            MansionHouse_Circle.AddTwoWayEdge(CannonStreet_Circle, 4);
            MansionHouse_Circle.AddTwoWayEdge(MansionHouse_District, 0);
            CannonStreet_Circle.AddTwoWayEdge(Monument_Circle, 5);
            CannonStreet_Circle.AddTwoWayEdge(CannonStreet_District, 0);
            Monument_Circle.AddTwoWayEdge(TowerHill_Circle, 10);
            Monument_Circle.AddTwoWayEdge(Monument_District, 0);
            Monument_Circle.AddTwoWayEdge(Monument_Northern, 0);
            TowerHill_Circle.AddTwoWayEdge(Aldgate_Circle, 9);
            TowerHill_Circle.AddTwoWayEdge(TowerHill_District, 0);
            Aldgate_Circle.AddTwoWayEdge(LiverpoolStreet_Circle, 9);
            Aldgate_Circle.AddTwoWayEdge(Aldgate_Metro, 0);
            LiverpoolStreet_Circle.AddTwoWayEdge(Moorgate_Circle, 6);
            LiverpoolStreet_Circle.AddTwoWayEdge(LiverpoolStreet_Central, 0);
            LiverpoolStreet_Circle.AddTwoWayEdge(LiverpoolStreet_Ham, 0);
            LiverpoolStreet_Circle.AddTwoWayEdge(LiverpoolStreet_Metro, 0);
            Moorgate_Circle.AddTwoWayEdge(Barbican_Circle, 10);
            Moorgate_Circle.AddTwoWayEdge(Moorgate_Ham, 0);
            Moorgate_Circle.AddTwoWayEdge(Moorgate_Metro, 0);
            Moorgate_Circle.AddTwoWayEdge(Moorgate_Northern, 0);
            Barbican_Circle.AddTwoWayEdge(Farringdon_Circle, 8);
            Barbican_Circle.AddTwoWayEdge(Barbican_Ham, 0);
            Barbican_Circle.AddTwoWayEdge(Barbican_Metro, 0);
            Farringdon_Circle.AddTwoWayEdge(KingsCrossStPancras_Circle, 26);
            Farringdon_Circle.AddTwoWayEdge(Farringdon_Ham, 0);
            Farringdon_Circle.AddTwoWayEdge(Farringdon_Metro, 0);
            KingsCrossStPancras_Circle.AddTwoWayEdge(EustonSquare_Circle, 15);
            KingsCrossStPancras_Circle.AddTwoWayEdge(KingsCrossStPancras_Ham, 0);
            KingsCrossStPancras_Circle.AddTwoWayEdge(KingsCrossStPancras_Metro, 0);
            KingsCrossStPancras_Circle.AddTwoWayEdge(KingsCrossStPancras_Northern, 0);
            KingsCrossStPancras_Circle.AddTwoWayEdge(KingsCrossStPancras_Piccadilly, 0);
            KingsCrossStPancras_Circle.AddTwoWayEdge(KingsCrossStPancras_Victoria, 0);
            EustonSquare_Circle.AddTwoWayEdge(GreatPortlandStreet_Circle, 10);
            EustonSquare_Circle.AddTwoWayEdge(EustonSquare_Ham, 0);
            EustonSquare_Circle.AddTwoWayEdge(EustonSquare_Metro, 0);
            GreatPortlandStreet_Circle.AddTwoWayEdge(BakerStreet_Circle, 13);
            GreatPortlandStreet_Circle.AddTwoWayEdge(GreatPortlandStreet_Ham, 0);
            GreatPortlandStreet_Circle.AddTwoWayEdge(GreatPortlandStreet_Metro, 0);
            BakerStreet_Circle.AddTwoWayEdge(EdgwareRoad_Circle, 10);

            //DISTRICT LINE
            EdgwareRoad_District.AddTwoWayEdge(Paddington_District, 10);
            Paddington_District.AddTwoWayEdge(Bayswater_District, 17);
            Bayswater_District.AddTwoWayEdge(NottinghillGate_District, 10);
            NottinghillGate_District.AddTwoWayEdge(HighStreetKensington_District, 13);
            HighStreetKensington_District.AddTwoWayEdge(GloucesterRoad_District, 18);
            GloucesterRoad_District.AddTwoWayEdge(SouthKensington_District, 8);
            SouthKensington_District.AddTwoWayEdge(SloaneSquare_District, 17);
            SloaneSquare_District.AddTwoWayEdge(Victoria_District, 13);
            Victoria_District.AddTwoWayEdge(StJamessPark_District, 11);
            StJamessPark_District.AddTwoWayEdge(Westminster_District, 11);
            Westminster_District.AddTwoWayEdge(Embankment_District, 10);
            Embankment_District.AddTwoWayEdge(Temple_District, 9);
            Temple_District.AddTwoWayEdge(Blackfriars_District, 10);
            Blackfriars_District.AddTwoWayEdge(MansionHouse_District, 10);
            MansionHouse_District.AddTwoWayEdge(CannonStreet_District, 4);
            CannonStreet_District.AddTwoWayEdge(Monument_District, 5);
            Monument_District.AddTwoWayEdge(TowerHill_District, 10);
            TowerHill_District.AddTwoWayEdge(AldgateEast_District, 10);
            AldgateEast_District.AddTwoWayEdge(AldgateEast_Ham, 0);

            //Hammersmith and City Line
            Paddington_Ham.AddTwoWayEdge(EdgwareRoad_Ham, 10);
            EdgwareRoad_Ham.AddTwoWayEdge(BakerStreet_Ham, 10);
            BakerStreet_Ham.AddTwoWayEdge(GreatPortlandStreet_Ham, 13);
            GreatPortlandStreet_Ham.AddTwoWayEdge(EustonSquare_Ham, 10);
            EustonSquare_Ham.AddTwoWayEdge(KingsCrossStPancras_Ham, 15);
            KingsCrossStPancras_Ham.AddTwoWayEdge(Farringdon_Ham, 26);
            Farringdon_Ham.AddTwoWayEdge(Barbican_Ham, 8);
            Barbican_Ham.AddTwoWayEdge(Moorgate_Ham, 10);
            Moorgate_Ham.AddTwoWayEdge(LiverpoolStreet_Ham, 6);
            LiverpoolStreet_Ham.AddTwoWayEdge(AldgateEast_Ham, 11);

            //JUBILEE
            BakerStreet_Jubilee.AddTwoWayEdge(BondStreet_Jubilee, 16);
            BondStreet_Jubilee.AddTwoWayEdge(GreenPark_Jubilee, 14);
            BondStreet_Jubilee.AddTwoWayEdge(BondStreet_Central, 0);
            GreenPark_Jubilee.AddTwoWayEdge(Westminster_Jubilee, 21);
            GreenPark_Jubilee.AddTwoWayEdge(GreenPark_Piccadilly, 0);
            GreenPark_Jubilee.AddTwoWayEdge(GreenPark_Victoria, 0);
            Westminster_Jubilee.AddTwoWayEdge(Waterloo_Jubilee, 17);
            Waterloo_Jubilee.AddTwoWayEdge(Southwark, 8);
            Southwark.AddTwoWayEdge(LondonBridge_Jubilee, 19);
            LondonBridge_Jubilee.AddTwoWayEdge(LondonBridge_Northern, 0);

            //METROPOLITAN
            BakerStreet_Metro.AddTwoWayEdge(GreatPortlandStreet_Metro, 13);
            GreatPortlandStreet_Metro.AddTwoWayEdge(EustonSquare_Metro, 10);
            EustonSquare_Metro.AddTwoWayEdge(KingsCrossStPancras_Metro, 15);
            KingsCrossStPancras_Metro.AddTwoWayEdge(Farringdon_Metro, 26);
            Farringdon_Metro.AddTwoWayEdge(Barbican_Metro, 8);
            Barbican_Metro.AddTwoWayEdge(Moorgate_Metro, 10);
            Moorgate_Metro.AddTwoWayEdge(LiverpoolStreet_Metro, 6);
            LiverpoolStreet_Metro.AddTwoWayEdge(Aldgate_Metro, 11);

            //NORTHERN
            Euston_Northern.AddTwoWayEdge(KingsCrossStPancras_Northern, 12);
            KingsCrossStPancras_Northern.AddTwoWayEdge(Angel, 16);
            Angel.AddTwoWayEdge(OldStreet, 20);
            OldStreet.AddTwoWayEdge(Moorgate_Northern, 9);
            Moorgate_Northern.AddTwoWayEdge(Monument_Northern, 9);
            Monument_Northern.AddTwoWayEdge(LondonBridge_Northern, 6);
            LondonBridge_Northern.AddTwoWayEdge(Borough, 9);
            Borough.AddTwoWayEdge(ElephantandCastle_Northern, 13);

            Euston_Northern.AddTwoWayEdge(WarrenStreet_Northern, 9);
            WarrenStreet_Northern.AddTwoWayEdge(GoodgeStreet, 7);
            WarrenStreet_Northern.AddTwoWayEdge(WarrenStreet_Victoria, 0);
            GoodgeStreet.AddTwoWayEdge(TottenhamCourtRoad_Northern, 7);
            TottenhamCourtRoad_Northern.AddTwoWayEdge(LeicesterSquare_Northern, 8);
            LeicesterSquare_Northern.AddTwoWayEdge(CharingCross_Northern, 7);
            LeicesterSquare_Northern.AddTwoWayEdge(LeicesterSquare_Piccadilly, 0);
            Embankment_Northern.AddTwoWayEdge(Waterloo_Northern, 6);

            //PICADILLI
            GloucesterRoad_Piccadilly.AddTwoWayEdge(SouthKensington_Piccadilly, 8);
            SouthKensington_Piccadilly.AddTwoWayEdge(Knightsbridge, 17);
            Knightsbridge.AddTwoWayEdge(HydeParkCorner, 7);
            HydeParkCorner.AddTwoWayEdge(GreenPark_Piccadilly, 12);
            GreenPark_Piccadilly.AddTwoWayEdge(Picadillycircus_Piccadilly, 8);
            Picadillycircus_Piccadilly.AddTwoWayEdge(LeicesterSquare_Piccadilly, 6);
            LeicesterSquare_Piccadilly.AddTwoWayEdge(CoventGarden, 4);
            CoventGarden.AddTwoWayEdge(Holborn_Piccadilly, 8);
            Holborn_Piccadilly.AddTwoWayEdge(RussellSquare, 9);
            RussellSquare.AddTwoWayEdge(KingsCrossStPancras_Piccadilly, 14);

            //VICTORIA
            Vauxhall.AddTwoWayEdge(Pimlico, 18);
            Pimlico.AddTwoWayEdge(Victoria_Victoria, 12);
            Victoria_Victoria.AddTwoWayEdge(GreenPark_Victoria, 19);
            GreenPark_Victoria.AddTwoWayEdge(OxfordCircus_Victoria, 15);
            OxfordCircus_Victoria.AddTwoWayEdge(WarrenStreet_Victoria, 18);
            WarrenStreet_Victoria.AddTwoWayEdge(KingsCrossStPancras_Victoria, 9);

            //Waterloo and City
            Waterloo_WaterlooAndCity.AddTwoWayEdge(Bank_WaterlooAndCity, 33);

            
            //CreateAdjList() method to create an adjacency list representation of the graph
            //Each entry in the list represents a station,
            //and the custom linked list at that entry contains the edges connecting that station to its neighbors
            MyList<MyLinkedList> adj = graph.CreateAdjList();
            MyList<MyLinkedList> adj2 = adj;
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine();
                Console.WriteLine("Please select your Role ");
                Console.WriteLine("1 - Admin");
                Console.WriteLine("2 - Customer");
                int roleChoice = Convert.ToInt32(Console.ReadLine());

                switch (roleChoice)
                {
                    case 1:
                        Console.WriteLine("Please select an option:");
                        Console.WriteLine("1. Add/remove journey walking time delays");
                        Console.WriteLine("2. Mark route as impossible/possible");
                        Console.WriteLine("3. Print impossible walking routes");
                        Console.WriteLine("4. Print delayed walking routes");
                        Console.WriteLine("5. Exit");

                        int adminChoice = Convert.ToInt32(Console.ReadLine());
                        switch (adminChoice)
                        {
                            case 1:
                                // Add this code where you want to add/remove delays and update the adjacency list
                                graph.AddRemoveDelays();
                                // This line updates the adjacency list after adding/removing delays
                                adj = graph.CreateAdjList(); 

                                break;
                            case 2:
                           
                                Console.WriteLine("Enter the starting station:");
                                string startStationName = Console.ReadLine();
                                Console.WriteLine("Enter the ending station:");
                                string endStationName = Console.ReadLine();

                                Console.WriteLine("Enter 1 to mark the route as possible or 0 to mark it as impossible:");
                                int possibleInput = Convert.ToInt32(Console.ReadLine());
                                bool isPossible = possibleInput == 1;

                                graph.MarkRoutePossibleOrImpossible(startStationName, endStationName, isPossible);
                             
                                break;
                            case 3:
                                // Call the function to print impossible walking routes
                                graph.PrintImpossibleWalkingRoutes();
                                break;
                            case 4:
                                graph.PrintDelayedWalkingRoutes(adj, adj2);
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Please select an option:");
                        Console.WriteLine("1. Find the fastest walking route");
                        Console.WriteLine("2. Display Tube Information");
                        Console.WriteLine("3.  Exit");

                        int customerChoice = Convert.ToInt32(Console.ReadLine());
                        switch (customerChoice)
                        {
                            case 1:
                                /////////////////////////////////////////////
                                /////             DIJKSTRA              /////
                                /////////////////////////////////////////////
                                ///
                                //define the source and target stations for the shortest path search
                                //Station source = Paddington_Bakerloo;
                                //Station target = EdgwareRoad_Bakerloo;

                                // Call the function to find the fastest walking route
                                Console.WriteLine("Enter the source station name:");
                                string sourceName = Console.ReadLine();
                                Console.WriteLine("Enter the target station name:");
                                string targetName = Console.ReadLine();

                                Station source = graph.GetStationByName(sourceName);
                                Station target = graph.GetStationByName(targetName);

                                if (source == null || target == null)
                                {
                                    Console.WriteLine("Invalid source or target station name. Please make sure you entered the correct names.");
                                    break; // or you can use a loop to ask for input again
                                }

                                graph.DijkstraAlgorithm(source, target, graph, adj);
                                break;
                            case 2:
                                Console.WriteLine("Please enter the Tube to Display its Information");
                                string name = Console.ReadLine();

                                Station station = graph.GetStationByName(name);
                                if (station != null)
                                {
                                    Console.WriteLine(station.ToString());
                                }
                                else
                                {
                                    Console.WriteLine("Invalid station name. Please make sure you entered the correct name.");
                                }
                                break;
                            default:
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }

        }
    }
}