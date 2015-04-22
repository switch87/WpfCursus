﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuinCentrumGemeenschap
{
    public class KlantenManager
    {
        public Boolean Klanttoevoegen( string naam, string adres, string postNr, string woonplaats )
        {
            var dbManager = new TuincentrumDbManager();

            using ( var conTuincentrum = dbManager.GetConnection() )
            {
                using ( var comNieuweKlant = conTuincentrum.CreateCommand() )
                {
                    comNieuweKlant.CommandType = System.Data.CommandType.StoredProcedure;
                    comNieuweKlant.CommandText = "leverancierToevoegen";

                    DbParameter parNaam = comNieuweKlant.CreateParameter();
                    DbParameter parAdres = comNieuweKlant.CreateParameter();
                    DbParameter parPostNr = comNieuweKlant.CreateParameter();
                    DbParameter parWoonplaats = comNieuweKlant.CreateParameter();

                    parNaam.ParameterName = "@naam";
                    parAdres.ParameterName = "@adres";
                    parPostNr.ParameterName = "@postNr";
                    parWoonplaats.ParameterName = "@woonplaats";

                    parNaam.Value = naam;
                    parAdres.Value = adres;
                    parPostNr.Value = postNr;
                    parWoonplaats.Value = woonplaats;

                    comNieuweKlant.Parameters.Add( parNaam );
                    comNieuweKlant.Parameters.Add( parAdres );
                    comNieuweKlant.Parameters.Add( parPostNr );
                    comNieuweKlant.Parameters.Add( parWoonplaats );

                    conTuincentrum.Open();
                    return comNieuweKlant.ExecuteNonQuery() != 0;
                }
            }
        }

        public void VervangLeverancier( int oudLevNr, int nieuwLevNr )
        {
            var manager = new TuincentrumDbManager();
            using ( var conTuin = manager.GetConnection() )
            {
                conTuin.Open();
                using ( var traVervangen =
                conTuin.BeginTransaction( IsolationLevel.ReadCommitted ) )
                {
                    using ( var comWijzigen = conTuin.CreateCommand() )
                    {
                        comWijzigen.Transaction = traVervangen;
                        comWijzigen.CommandType = CommandType.StoredProcedure;
                        comWijzigen.CommandText = "LeverancierWijzigen";
                        var parOudLevNr = comWijzigen.CreateParameter();
                        parOudLevNr.ParameterName = "@OudLevNr";
                        parOudLevNr.Value = oudLevNr;
                        comWijzigen.Parameters.Add( parOudLevNr );
                        var parNieuwLevNr = comWijzigen.CreateParameter();
                        parNieuwLevNr.ParameterName = "@NieuwLevNr";
                        parNieuwLevNr.Value = nieuwLevNr;
                        comWijzigen.Parameters.Add( parNieuwLevNr );
                        if ( comWijzigen.ExecuteNonQuery() == 0 )
                        {
                            traVervangen.Rollback();
                            throw new Exception( "Leverancier " + oudLevNr + " kon niet vervangen worden door " + nieuwLevNr );
                        }
                    }
                    using ( var comVerwijderen = conTuin.CreateCommand() )
                    {
                        comVerwijderen.Transaction = traVervangen;
                        comVerwijderen.CommandType = CommandType.StoredProcedure;
                        comVerwijderen.CommandText = "LeverancierVerwijderen";
                        var parLevNr = comVerwijderen.CreateParameter();
                        parLevNr.ParameterName = "@LevNr";
                        parLevNr.Value = oudLevNr;
                        comVerwijderen.Parameters.Add( parLevNr );
                        if ( comVerwijderen.ExecuteNonQuery() == 0 )
                        {
                            traVervangen.Rollback();
                            throw new Exception( "Leverancier " + oudLevNr + " kon niet verwijderd worden" );
                        }
                        traVervangen.Commit();
                    }
                }
            }
        }
    }
}
    
