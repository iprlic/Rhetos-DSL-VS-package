using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace Omega.RhetosDsl
{
    internal static class OrdinaryClassificationDefinition
    {
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Take")]
        internal static ClassificationTypeDefinition rhetosTake = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("LookupVisible")]
        internal static ClassificationTypeDefinition rhetosLookupVisible = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Action")]
        internal static ClassificationTypeDefinition rhetosAction = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("ActionGroup")]
        internal static ClassificationTypeDefinition rhetosActionGroup = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("AddSource")]
        internal static ClassificationTypeDefinition rhetosAddSource = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("All")]
        internal static ClassificationTypeDefinition rhetosAll = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("AllProperties")]
        internal static ClassificationTypeDefinition rhetosAllProperties = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("AllPropertiesFrom")]
        internal static ClassificationTypeDefinition rhetosAllPropertiesFrom = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("AllPropertiesWithCascadeDeleteFrom")]
        internal static ClassificationTypeDefinition rhetosAllPropertiesWithCascadeDeleteFrom = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("AutoCode")]
        internal static ClassificationTypeDefinition rhetosAutoCode = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("AutoCodeForEach")]
        internal static ClassificationTypeDefinition rhetosAutoCodeForEach = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Binary")]
        internal static ClassificationTypeDefinition rhetosBinary = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Bool")]
        internal static ClassificationTypeDefinition rhetosBool = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CalculationMenuItem")]
        internal static ClassificationTypeDefinition rhetosCalculationMenuItem = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Caption")]
        internal static ClassificationTypeDefinition rhetosCaption = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CascadeDelete")]
        internal static ClassificationTypeDefinition rhetosCascadeDelete = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("ChangesOnBaseItem")]
        internal static ClassificationTypeDefinition rhetosChangesOnBaseItem = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("ChangesOnChangedItems")]
        internal static ClassificationTypeDefinition rhetosChangesOnChangedItems = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("ChangesOnLinkedItems")]
        internal static ClassificationTypeDefinition rhetosChangesOnLinkedItems = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("ComposableFilterBy")]
        internal static ClassificationTypeDefinition rhetosComposableFilterBy = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Computed")]
        internal static ClassificationTypeDefinition rhetosComputed = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("ComputeForNewBaseItems")]
        internal static ClassificationTypeDefinition rhetosComputeForNewBaseItems = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("ConvertFormat")]
        internal static ClassificationTypeDefinition rhetosConvertFormat = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CreationTime")]
        internal static ClassificationTypeDefinition rhetosCreationTime = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Currency")]
        internal static ClassificationTypeDefinition rhetosCurrency = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CustomClaim")]
        internal static ClassificationTypeDefinition rhetosCustomClaim = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("DataSource")]
        internal static ClassificationTypeDefinition rhetosDataSource = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("DataSources")]
        internal static ClassificationTypeDefinition rhetosDataSources = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("DataStructure")]
        internal static ClassificationTypeDefinition rhetosDataStructure = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Date")]
        internal static ClassificationTypeDefinition rhetosDate = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("DateTime")]
        internal static ClassificationTypeDefinition rhetosDateTime = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Decimal")]
        internal static ClassificationTypeDefinition rhetosDecimal = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("DenySave")]
        internal static ClassificationTypeDefinition rhetosDenySave = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Dependency")]
        internal static ClassificationTypeDefinition rhetosDependency = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Description")]
        internal static ClassificationTypeDefinition rhetosDescription = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Detail")]
        internal static ClassificationTypeDefinition rhetosDetail = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Entity")]
        internal static ClassificationTypeDefinition rhetosEntity = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Extends")]
        internal static ClassificationTypeDefinition rhetosExtends = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("ExternalReference")]
        internal static ClassificationTypeDefinition rhetosExternalReference = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Filter")]
        internal static ClassificationTypeDefinition rhetosFilter = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("FilterBy")]
        internal static ClassificationTypeDefinition rhetosFilterBy = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("FilterByBase")]
        internal static ClassificationTypeDefinition rhetosFilterByBase = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("FilterByLinkedItems")]
        internal static ClassificationTypeDefinition rhetosFilterByLinkedItems = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("FilterByReferenced")]
        internal static ClassificationTypeDefinition rhetosFilterByReferenced = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("From")]
        internal static ClassificationTypeDefinition rhetosFrom = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("GuiBool")]
        internal static ClassificationTypeDefinition rhetosGuiBool = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("GuiBrowseDataStructure")]
        internal static ClassificationTypeDefinition rhetosGuiBrowseDataStructure = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("GuiCurrency")]
        internal static ClassificationTypeDefinition rhetosGuiCurrency = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Guid")]
        internal static ClassificationTypeDefinition rhetosGuid = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("GuiDataStructure")]
        internal static ClassificationTypeDefinition rhetosGuiDataStructure = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("GuiDate")]
        internal static ClassificationTypeDefinition rhetosGuiDate = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("GuiDateTime")]
        internal static ClassificationTypeDefinition rhetosGuiDateTime = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("GuiDecimal")]
        internal static ClassificationTypeDefinition rhetosGuiDecimal = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("GuiInteger")]
        internal static ClassificationTypeDefinition rhetosGuiInteger = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("GuiLegacyLookup")]
        internal static ClassificationTypeDefinition rhetosGuiLegacyLookup = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("GuiLongString")]
        internal static ClassificationTypeDefinition rhetosGuiLongString = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("GuiMoney")]
        internal static ClassificationTypeDefinition rhetosGuiMoney = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("GuiReference")]
        internal static ClassificationTypeDefinition rhetosGuiReference = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("GuiReport")]
        internal static ClassificationTypeDefinition rhetosGuiReport = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("GuiSection")]
        internal static ClassificationTypeDefinition rhetosGuiSection = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("GuiShortString")]
        internal static ClassificationTypeDefinition rhetosGuiShortString = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("GuiUniReport")]
        internal static ClassificationTypeDefinition rhetosGuiUniReport = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Hierarchy")]
        internal static ClassificationTypeDefinition rhetosHierarchy = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("History")]
        internal static ClassificationTypeDefinition rhetosHistory = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Implements")]
        internal static ClassificationTypeDefinition rhetosImplements = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Integer")]
        internal static ClassificationTypeDefinition rhetosInteger = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("ItemFilter")]
        internal static ClassificationTypeDefinition rhetosItemFilter = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("KeepSynchronized")]
        internal static ClassificationTypeDefinition rhetosKeepSynchronized = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("LegacyEntity")]
        internal static ClassificationTypeDefinition rhetosLegacyEntity = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("LegacyProperty")]
        internal static ClassificationTypeDefinition rhetosLegacyProperty = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("LegacyPropertyReadOnly")]
        internal static ClassificationTypeDefinition rhetosLegacyPropertyReadOnly = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("LinkedItems")]
        internal static ClassificationTypeDefinition rhetosLinkedItems = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Lock")]
        internal static ClassificationTypeDefinition rhetosLock = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("LockProperty")]
        internal static ClassificationTypeDefinition rhetosLockProperty = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Log")]
        internal static ClassificationTypeDefinition rhetosLog = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Logging")]
        internal static ClassificationTypeDefinition rhetosLogging = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("LongString")]
        internal static ClassificationTypeDefinition rhetosLongString = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("MaxLength")]
        internal static ClassificationTypeDefinition rhetosMaxLength = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Menu")]
        internal static ClassificationTypeDefinition rhetosMenu = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("MenuItem")]
        internal static ClassificationTypeDefinition rhetosMenuItem = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("ModificationTimeOf")]
        internal static ClassificationTypeDefinition rhetosModificationTimeOf = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Module")]
        internal static ClassificationTypeDefinition rhetosModule = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Money")]
        internal static ClassificationTypeDefinition rhetosMoney = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Parameter")]
        internal static ClassificationTypeDefinition rhetosParameter = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Persisted")]
        internal static ClassificationTypeDefinition rhetosPersisted = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("PessimisticLocking")]
        internal static ClassificationTypeDefinition rhetosPessimisticLocking = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("PessimisticLockingParent")]
        internal static ClassificationTypeDefinition rhetosPessimisticLockingParent = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("PrerequisiteAllProperties")]
        internal static ClassificationTypeDefinition rhetosPrerequisiteAllProperties = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("PropertyFrom")]
        internal static ClassificationTypeDefinition rhetosPropertyFrom = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("QueryableExtension")]
        internal static ClassificationTypeDefinition rhetosQueryableExtension = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Reference")]
        internal static ClassificationTypeDefinition rhetosReference = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("ReportData")]
        internal static ClassificationTypeDefinition rhetosReportData = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("ReportFile")]
        internal static ClassificationTypeDefinition rhetosReportFile = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("ReportSpecification")]
        internal static ClassificationTypeDefinition rhetosReportSpecification = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Required")]
        internal static ClassificationTypeDefinition rhetosRequired = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("RequiredClaim")]
        internal static ClassificationTypeDefinition rhetosRequiredClaim = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Shortcut")]
        internal static ClassificationTypeDefinition rhetosShortcut = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("ShortString")]
        internal static ClassificationTypeDefinition rhetosShortString = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("SingleRoot")]
        internal static ClassificationTypeDefinition rhetosSingleRoot = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("SqlDefault")]
        internal static ClassificationTypeDefinition rhetosSqlDefault = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("SqlDependsOn")]
        internal static ClassificationTypeDefinition rhetosSqlDependsOn = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("SqlDependsOnFunction")]
        internal static ClassificationTypeDefinition rhetosSqlDependsOnFunction = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("SqlDependsOnSqlObject")]
        internal static ClassificationTypeDefinition rhetosSqlDependsOnSqlObject = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("SqlDependsOnView")]
        internal static ClassificationTypeDefinition rhetosSqlDependsOnView = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("SqlFunction")]
        internal static ClassificationTypeDefinition rhetosSqlFunction = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("SqlIndex")]
        internal static ClassificationTypeDefinition rhetosSqlIndex = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("SqlIndexMultiple")]
        internal static ClassificationTypeDefinition rhetosSqlIndexMultiple = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("SqlObject")]
        internal static ClassificationTypeDefinition rhetosSqlObject = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("SqlProcedure")]
        internal static ClassificationTypeDefinition rhetosSqlProcedure = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("SqlQueryable")]
        internal static ClassificationTypeDefinition rhetosSqlQueryable = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("SqlTrigger")]
        internal static ClassificationTypeDefinition rhetosSqlTrigger = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("SqlView")]
        internal static ClassificationTypeDefinition rhetosSqlView = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("TemplaterReport")]
        internal static ClassificationTypeDefinition rhetosTemplaterReport = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Unique")]
        internal static ClassificationTypeDefinition rhetosUnique = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("UniqueMultiple")]
        internal static ClassificationTypeDefinition rhetosUniqueMultiple = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("UseExecutionContext")]
        internal static ClassificationTypeDefinition rhetosUseExecutionContext = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("ValidationMenuItem")]
        internal static ClassificationTypeDefinition rhetosValidationMenuItem = null;


        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Browse")]
        internal static ClassificationTypeDefinition rhetosBrowse = null;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Browseable")]
        internal static ClassificationTypeDefinition rhetosBrowseable = null;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name("SmartSearch")]
        internal static ClassificationTypeDefinition rhetosSmartSearch = null;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name("RhetosComment")]
        internal static ClassificationTypeDefinition rhetosComment = null;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name("RhetosError")]
        internal static ClassificationTypeDefinition rhetosError = null;
    }
}
