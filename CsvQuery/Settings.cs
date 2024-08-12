﻿namespace CsvQuery
{
    using System.ComponentModel;
    using Database;
    using PluginInfrastructure;

    /// <summary>
    /// Manages application settings
    /// </summary>
    public class Settings : SettingsBase
    {
        [Description("In debugmode extra diagnostics are output"), Category("General"), DefaultValue(false)]
        public bool DebugMode { get; set; }

        [Description("Separators that are detected automatically"), Category("General"), DefaultValue(",;|\\t")]
        public string Separators { get; set; } = ",;|\\t:";

        [Description("Saves the query cache to disk between boots"), Category("General"), DefaultValue(true)]
        public bool SaveQueryCache { get; set; }

        [Description("Show row numbers"), Category("General"), DefaultValue(true)]
        public bool ShowRowNumbers { get; set; }

        [Description("Default separators when generating CSV"), Category("Generation"), DefaultValue(",")]
        public string DefaultSeparator { get; set; }

        [Description("Default quote escape character when quotes exists inside text"), Category("Generation"), DefaultValue('\"')]
        public char DefaultQuoteChar { get; set; }

        [Description("SQL provider for data storage"), Category("SQL"), DefaultValue(DataStorageProvider.SQLite)]
        public DataStorageProvider StorageProvider { get; set; }

        [Description("For SQLite a file path or ':memory:' for in-memory database. \r\nFor MSSQL name of database in local default instance (trusted connection)"), Category("SQL"), DefaultValue(":memory:")]
        public string Database { get; set; }

        [Description("If true guesses the column types when creating database table"), Category("SQL"), DefaultValue(false)]
        public bool DetectDbColumnTypes { get; set; }

        [Description("If true converts strings starting with zeroes (e.g. 0014) to numbers"), Category("General"), DefaultValue(false)]
        public bool ConvertInitialZerosToNumber { get; set; }

        [Description("Maximum length of a numeric string before it's considered a string instead"), Category("General"), DefaultValue(10)]
        public int MaxIntegerStringLength { get; set; }

        [Description("Datagrid cell font size"), Category("General"), DefaultValue(9)]
        public int DatagridCellFontSize { get; set; }

        [Description("Use colors from Notepad++ theme"), Category("General"), DefaultValue(false)]
        public bool UseNppStyling { get; set; }

        [Description("Use original headers when generating a new CSV (only works on THIS-queries)"), Category("Generation"), DefaultValue(true)]
        public bool UseOriginalColumnHeadersOnGeneratedCsv { get; set; }

        [Description("(Experimental) Read XML files and try to find line-similar entries"), Category("General"), DefaultValue(false)]
        public bool ParseXmlFiles { get; set; }
    }
}