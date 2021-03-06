﻿using System;
using System.Collections.Generic;
using System.Data;
using HydroDesktop.Database;
using HydroDesktop.Interfaces.ObjectModel;
using HydroDesktop.Interfaces;

namespace Search3.Searching
{
    /// <summary>
    /// Searches in the 'MetadataCache' database
    /// use this class when the "Metadata Cache" search
    /// option is selected
    /// </summary>
    public class MetadataCacheSearcher : SeriesSearcher
    {
        #region Fields

        private readonly MetadataCacheManagerSQL _db;

        #endregion

        #region Constructors

        public MetadataCacheSearcher()
        {
            _db = new MetadataCacheManagerSQL(DatabaseTypes.SQLite, HydroDesktop.Configuration.Settings.Instance.MetadataCacheConnectionString);
        }

        #endregion

        /// <summary>
        /// Get a list of all keywords from all web services in the metadata cache db
        /// </summary>
        public IList<string> GetKeywords()
        {
            return _db.GetVariableNames();
        }

        /// <summary>
        /// Get a list of all web services registered in the metadata cache database
        /// </summary>
        public IEnumerable<DataServiceInfo> GetWebServices()
        {
            return _db.GetAllServices();
        }

        protected override IEnumerable<SeriesDataCart> GetSeriesCatalogForBox(double xMin, double xMax, double yMin, double yMax, string keyword,
            DateTime startDate, DateTime endDate, int[] networkIDs)
        {
            var dt = _db.GetSeriesDataTableInBox(xMin, xMax, yMin, yMax, new []{keyword}, startDate, endDate, networkIDs);

            var seriesList = new List<SeriesDataCart>(dt.Rows.Count);
            foreach (DataRow row in dt.Rows)
            {
                var series = _db.SeriesDataCartFromRow(row);
                if (series != null)
                {
                    // Update BeginDate/EndDate/ValueCount to the user-specified range
                    SearchHelper.UpdateDataCartToDateInterval(series, startDate, endDate);
                    seriesList.Add(series);
                }
            }
            return seriesList;
        }
    }
}
