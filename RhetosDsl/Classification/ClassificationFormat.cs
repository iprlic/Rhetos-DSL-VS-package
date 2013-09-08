using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;


namespace Omega.RhetosDsl
{
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Take")]
    [Name("Take")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosTake : ClassificationFormatDefinition
    {
        public RhetosTake()
        {
            DisplayName = "Take";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "LookupVisible")]
    [Name("LookupVisible")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosLookupVisible : ClassificationFormatDefinition
    {
        public RhetosLookupVisible()
        {
            DisplayName = "LookupVisible";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Action")]
    [Name("Action")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosAction : ClassificationFormatDefinition
    {
        public RhetosAction()
        {
            DisplayName = "Action";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "ActionGroup")]
    [Name("ActionGroup")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosActionGroup : ClassificationFormatDefinition
    {
        public RhetosActionGroup()
        {
            DisplayName = "ActionGroup";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "AddSource")]
    [Name("AddSource")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosAddSource : ClassificationFormatDefinition
    {
        public RhetosAddSource()
        {
            DisplayName = "AddSource";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "All")]
    [Name("All")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosAll : ClassificationFormatDefinition
    {
        public RhetosAll()
        {
            DisplayName = "All";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "AllProperties")]
    [Name("AllProperties")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosAllProperties : ClassificationFormatDefinition
    {
        public RhetosAllProperties()
        {
            DisplayName = "AllProperties";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "AllPropertiesFrom")]
    [Name("AllPropertiesFrom")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosAllPropertiesFrom : ClassificationFormatDefinition
    {
        public RhetosAllPropertiesFrom()
        {
            DisplayName = "AllPropertiesFrom";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "AllPropertiesWithCascadeDeleteFrom")]
    [Name("AllPropertiesWithCascadeDeleteFrom")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosAllPropertiesWithCascadeDeleteFrom : ClassificationFormatDefinition
    {
        public RhetosAllPropertiesWithCascadeDeleteFrom()
        {
            DisplayName = "AllPropertiesWithCascadeDeleteFrom";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "AutoCode")]
    [Name("AutoCode")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosAutoCode : ClassificationFormatDefinition
    {
        public RhetosAutoCode()
        {
            DisplayName = "AutoCode";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "AutoCodeForEach")]
    [Name("AutoCodeForEach")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosAutoCodeForEach : ClassificationFormatDefinition
    {
        public RhetosAutoCodeForEach()
        {
            DisplayName = "AutoCodeForEach";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Binary")]
    [Name("Binary")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosBinary : ClassificationFormatDefinition
    {
        public RhetosBinary()
        {
            DisplayName = "Binary";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Bool")]
    [Name("Bool")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosBool : ClassificationFormatDefinition
    {
        public RhetosBool()
        {
            DisplayName = "Bool";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "CalculationMenuItem")]
    [Name("CalculationMenuItem")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosCalculationMenuItem : ClassificationFormatDefinition
    {
        public RhetosCalculationMenuItem()
        {
            DisplayName = "CalculationMenuItem";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Caption")]
    [Name("Caption")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosCaption : ClassificationFormatDefinition
    {
        public RhetosCaption()
        {
            DisplayName = "Caption";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "CascadeDelete")]
    [Name("CascadeDelete")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosCascadeDelete : ClassificationFormatDefinition
    {
        public RhetosCascadeDelete()
        {
            DisplayName = "CascadeDelete";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "ChangesOnBaseItem")]
    [Name("ChangesOnBaseItem")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosChangesOnBaseItem : ClassificationFormatDefinition
    {
        public RhetosChangesOnBaseItem()
        {
            DisplayName = "ChangesOnBaseItem";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "ChangesOnChangedItems")]
    [Name("ChangesOnChangedItems")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosChangesOnChangedItems : ClassificationFormatDefinition
    {
        public RhetosChangesOnChangedItems()
        {
            DisplayName = "ChangesOnChangedItems";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "ChangesOnLinkedItems")]
    [Name("ChangesOnLinkedItems")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosChangesOnLinkedItems : ClassificationFormatDefinition
    {
        public RhetosChangesOnLinkedItems()
        {
            DisplayName = "ChangesOnLinkedItems";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "ComposableFilterBy")]
    [Name("ComposableFilterBy")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosComposableFilterBy : ClassificationFormatDefinition
    {
        public RhetosComposableFilterBy()
        {
            DisplayName = "ComposableFilterBy";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Computed")]
    [Name("Computed")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosComputed : ClassificationFormatDefinition
    {
        public RhetosComputed()
        {
            DisplayName = "Computed";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "ComputeForNewBaseItems")]
    [Name("ComputeForNewBaseItems")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosComputeForNewBaseItems : ClassificationFormatDefinition
    {
        public RhetosComputeForNewBaseItems()
        {
            DisplayName = "ComputeForNewBaseItems";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "ConvertFormat")]
    [Name("ConvertFormat")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosConvertFormat : ClassificationFormatDefinition
    {
        public RhetosConvertFormat()
        {
            DisplayName = "ConvertFormat";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "CreationTime")]
    [Name("CreationTime")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosCreationTime : ClassificationFormatDefinition
    {
        public RhetosCreationTime()
        {
            DisplayName = "CreationTime";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Currency")]
    [Name("Currency")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosCurrency : ClassificationFormatDefinition
    {
        public RhetosCurrency()
        {
            DisplayName = "Currency";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "CustomClaim")]
    [Name("CustomClaim")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosCustomClaim : ClassificationFormatDefinition
    {
        public RhetosCustomClaim()
        {
            DisplayName = "CustomClaim";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "DataSource")]
    [Name("DataSource")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosDataSource : ClassificationFormatDefinition
    {
        public RhetosDataSource()
        {
            DisplayName = "DataSource";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "DataSources")]
    [Name("DataSources")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosDataSources : ClassificationFormatDefinition
    {
        public RhetosDataSources()
        {
            DisplayName = "DataSources";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "DataStructure")]
    [Name("DataStructure")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosDataStructure : ClassificationFormatDefinition
    {
        public RhetosDataStructure()
        {
            DisplayName = "DataStructure";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Date")]
    [Name("Date")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosDate : ClassificationFormatDefinition
    {
        public RhetosDate()
        {
            DisplayName = "Date";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "DateTime")]
    [Name("DateTime")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosDateTime : ClassificationFormatDefinition
    {
        public RhetosDateTime()
        {
            DisplayName = "DateTime";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Decimal")]
    [Name("Decimal")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosDecimal : ClassificationFormatDefinition
    {
        public RhetosDecimal()
        {
            DisplayName = "Decimal";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "DenySave")]
    [Name("DenySave")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosDenySave : ClassificationFormatDefinition
    {
        public RhetosDenySave()
        {
            DisplayName = "DenySave";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Dependency")]
    [Name("Dependency")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosDependency : ClassificationFormatDefinition
    {
        public RhetosDependency()
        {
            DisplayName = "Dependency";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Description")]
    [Name("Description")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosDescription : ClassificationFormatDefinition
    {
        public RhetosDescription()
        {
            DisplayName = "Description";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Detail")]
    [Name("Detail")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosDetail : ClassificationFormatDefinition
    {
        public RhetosDetail()
        {
            DisplayName = "Detail";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Entity")]
    [Name("Entity")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosEntity : ClassificationFormatDefinition
    {
        public RhetosEntity()
        {
            DisplayName = "Entity";
            ForegroundColor = Colors.BlueViolet;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Extends")]
    [Name("Extends")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosExtends : ClassificationFormatDefinition
    {
        public RhetosExtends()
        {
            DisplayName = "Extends";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "ExternalReference")]
    [Name("ExternalReference")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosExternalReference : ClassificationFormatDefinition
    {
        public RhetosExternalReference()
        {
            DisplayName = "ExternalReference";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Filter")]
    [Name("Filter")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosFilter : ClassificationFormatDefinition
    {
        public RhetosFilter()
        {
            DisplayName = "Filter";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "FilterBy")]
    [Name("FilterBy")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosFilterBy : ClassificationFormatDefinition
    {
        public RhetosFilterBy()
        {
            DisplayName = "FilterBy";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "FilterByBase")]
    [Name("FilterByBase")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosFilterByBase : ClassificationFormatDefinition
    {
        public RhetosFilterByBase()
        {
            DisplayName = "FilterByBase";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "FilterByLinkedItems")]
    [Name("FilterByLinkedItems")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosFilterByLinkedItems : ClassificationFormatDefinition
    {
        public RhetosFilterByLinkedItems()
        {
            DisplayName = "FilterByLinkedItems";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "FilterByReferenced")]
    [Name("FilterByReferenced")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosFilterByReferenced : ClassificationFormatDefinition
    {
        public RhetosFilterByReferenced()
        {
            DisplayName = "FilterByReferenced";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "From")]
    [Name("From")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosFrom : ClassificationFormatDefinition
    {
        public RhetosFrom()
        {
            DisplayName = "From";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "GuiBool")]
    [Name("GuiBool")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosGuiBool : ClassificationFormatDefinition
    {
        public RhetosGuiBool()
        {
            DisplayName = "GuiBool";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "GuiBrowseDataStructure")]
    [Name("GuiBrowseDataStructure")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosGuiBrowseDataStructure : ClassificationFormatDefinition
    {
        public RhetosGuiBrowseDataStructure()
        {
            DisplayName = "GuiBrowseDataStructure";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "GuiCurrency")]
    [Name("GuiCurrency")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosGuiCurrency : ClassificationFormatDefinition
    {
        public RhetosGuiCurrency()
        {
            DisplayName = "GuiCurrency";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Guid")]
    [Name("Guid")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosGuid : ClassificationFormatDefinition
    {
        public RhetosGuid()
        {
            DisplayName = "Guid";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "GuiDataStructure")]
    [Name("GuiDataStructure")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosGuiDataStructure : ClassificationFormatDefinition
    {
        public RhetosGuiDataStructure()
        {
            DisplayName = "GuiDataStructure";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "GuiDate")]
    [Name("GuiDate")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosGuiDate : ClassificationFormatDefinition
    {
        public RhetosGuiDate()
        {
            DisplayName = "GuiDate";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "GuiDateTime")]
    [Name("GuiDateTime")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosGuiDateTime : ClassificationFormatDefinition
    {
        public RhetosGuiDateTime()
        {
            DisplayName = "GuiDateTime";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "GuiDecimal")]
    [Name("GuiDecimal")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosGuiDecimal : ClassificationFormatDefinition
    {
        public RhetosGuiDecimal()
        {
            DisplayName = "GuiDecimal";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "GuiInteger")]
    [Name("GuiInteger")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosGuiInteger : ClassificationFormatDefinition
    {
        public RhetosGuiInteger()
        {
            DisplayName = "GuiInteger";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "GuiLegacyLookup")]
    [Name("GuiLegacyLookup")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosGuiLegacyLookup : ClassificationFormatDefinition
    {
        public RhetosGuiLegacyLookup()
        {
            DisplayName = "GuiLegacyLookup";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "GuiLongString")]
    [Name("GuiLongString")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosGuiLongString : ClassificationFormatDefinition
    {
        public RhetosGuiLongString()
        {
            DisplayName = "GuiLongString";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "GuiMoney")]
    [Name("GuiMoney")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosGuiMoney : ClassificationFormatDefinition
    {
        public RhetosGuiMoney()
        {
            DisplayName = "GuiMoney";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "GuiReference")]
    [Name("GuiReference")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosGuiReference : ClassificationFormatDefinition
    {
        public RhetosGuiReference()
        {
            DisplayName = "GuiReference";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "GuiReport")]
    [Name("GuiReport")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosGuiReport : ClassificationFormatDefinition
    {
        public RhetosGuiReport()
        {
            DisplayName = "GuiReport";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "GuiSection")]
    [Name("GuiSection")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosGuiSection : ClassificationFormatDefinition
    {
        public RhetosGuiSection()
        {
            DisplayName = "GuiSection";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "GuiShortString")]
    [Name("GuiShortString")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosGuiShortString : ClassificationFormatDefinition
    {
        public RhetosGuiShortString()
        {
            DisplayName = "GuiShortString";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "GuiUniReport")]
    [Name("GuiUniReport")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosGuiUniReport : ClassificationFormatDefinition
    {
        public RhetosGuiUniReport()
        {
            DisplayName = "GuiUniReport";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Hierarchy")]
    [Name("Hierarchy")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosHierarchy : ClassificationFormatDefinition
    {
        public RhetosHierarchy()
        {
            DisplayName = "Hierarchy";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "History")]
    [Name("History")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosHistory : ClassificationFormatDefinition
    {
        public RhetosHistory()
        {
            DisplayName = "History";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Implements")]
    [Name("Implements")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosImplements : ClassificationFormatDefinition
    {
        public RhetosImplements()
        {
            DisplayName = "Implements";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Integer")]
    [Name("Integer")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosInteger : ClassificationFormatDefinition
    {
        public RhetosInteger()
        {
            DisplayName = "Integer";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "ItemFilter")]
    [Name("ItemFilter")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosItemFilter : ClassificationFormatDefinition
    {
        public RhetosItemFilter()
        {
            DisplayName = "ItemFilter";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "KeepSynchronized")]
    [Name("KeepSynchronized")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosKeepSynchronized : ClassificationFormatDefinition
    {
        public RhetosKeepSynchronized()
        {
            DisplayName = "KeepSynchronized";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "LegacyEntity")]
    [Name("LegacyEntity")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosLegacyEntity : ClassificationFormatDefinition
    {
        public RhetosLegacyEntity()
        {
            DisplayName = "LegacyEntity";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "LegacyProperty")]
    [Name("LegacyProperty")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosLegacyProperty : ClassificationFormatDefinition
    {
        public RhetosLegacyProperty()
        {
            DisplayName = "LegacyProperty";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "LegacyPropertyReadOnly")]
    [Name("LegacyPropertyReadOnly")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosLegacyPropertyReadOnly : ClassificationFormatDefinition
    {
        public RhetosLegacyPropertyReadOnly()
        {
            DisplayName = "LegacyPropertyReadOnly";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "LinkedItems")]
    [Name("LinkedItems")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosLinkedItems : ClassificationFormatDefinition
    {
        public RhetosLinkedItems()
        {
            DisplayName = "LinkedItems";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Lock")]
    [Name("Lock")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosLock : ClassificationFormatDefinition
    {
        public RhetosLock()
        {
            DisplayName = "Lock";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "LockProperty")]
    [Name("LockProperty")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosLockProperty : ClassificationFormatDefinition
    {
        public RhetosLockProperty()
        {
            DisplayName = "LockProperty";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Log")]
    [Name("Log")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosLog : ClassificationFormatDefinition
    {
        public RhetosLog()
        {
            DisplayName = "Log";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Logging")]
    [Name("Logging")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosLogging : ClassificationFormatDefinition
    {
        public RhetosLogging()
        {
            DisplayName = "Logging";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "LongString")]
    [Name("LongString")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosLongString : ClassificationFormatDefinition
    {
        public RhetosLongString()
        {
            DisplayName = "LongString";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "MaxLength")]
    [Name("MaxLength")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosMaxLength : ClassificationFormatDefinition
    {
        public RhetosMaxLength()
        {
            DisplayName = "MaxLength";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Menu")]
    [Name("Menu")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosMenu : ClassificationFormatDefinition
    {
        public RhetosMenu()
        {
            DisplayName = "Menu";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "MenuItem")]
    [Name("MenuItem")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosMenuItem : ClassificationFormatDefinition
    {
        public RhetosMenuItem()
        {
            DisplayName = "MenuItem";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "ModificationTimeOf")]
    [Name("ModificationTimeOf")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosModificationTimeOf : ClassificationFormatDefinition
    {
        public RhetosModificationTimeOf()
        {
            DisplayName = "ModificationTimeOf";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Module")]
    [Name("Module")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosModule : ClassificationFormatDefinition
    {
        public RhetosModule()
        {
            DisplayName = "Module";
            ForegroundColor = Colors.Blue;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Money")]
    [Name("Money")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosMoney : ClassificationFormatDefinition
    {
        public RhetosMoney()
        {
            DisplayName = "Money";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Parameter")]
    [Name("Parameter")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosParameter : ClassificationFormatDefinition
    {
        public RhetosParameter()
        {
            DisplayName = "Parameter";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Persisted")]
    [Name("Persisted")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosPersisted : ClassificationFormatDefinition
    {
        public RhetosPersisted()
        {
            DisplayName = "Persisted";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "PessimisticLocking")]
    [Name("PessimisticLocking")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosPessimisticLocking : ClassificationFormatDefinition
    {
        public RhetosPessimisticLocking()
        {
            DisplayName = "PessimisticLocking";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "PessimisticLockingParent")]
    [Name("PessimisticLockingParent")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosPessimisticLockingParent : ClassificationFormatDefinition
    {
        public RhetosPessimisticLockingParent()
        {
            DisplayName = "PessimisticLockingParent";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "PrerequisiteAllProperties")]
    [Name("PrerequisiteAllProperties")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosPrerequisiteAllProperties : ClassificationFormatDefinition
    {
        public RhetosPrerequisiteAllProperties()
        {
            DisplayName = "PrerequisiteAllProperties";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "PropertyFrom")]
    [Name("PropertyFrom")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosPropertyFrom : ClassificationFormatDefinition
    {
        public RhetosPropertyFrom()
        {
            DisplayName = "PropertyFrom";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "QueryableExtension")]
    [Name("QueryableExtension")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosQueryableExtension : ClassificationFormatDefinition
    {
        public RhetosQueryableExtension()
        {
            DisplayName = "QueryableExtension";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Reference")]
    [Name("Reference")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosReference : ClassificationFormatDefinition
    {
        public RhetosReference()
        {
            DisplayName = "Reference";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "ReportData")]
    [Name("ReportData")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosReportData : ClassificationFormatDefinition
    {
        public RhetosReportData()
        {
            DisplayName = "ReportData";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "ReportFile")]
    [Name("ReportFile")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosReportFile : ClassificationFormatDefinition
    {
        public RhetosReportFile()
        {
            DisplayName = "ReportFile";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "ReportSpecification")]
    [Name("ReportSpecification")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosReportSpecification : ClassificationFormatDefinition
    {
        public RhetosReportSpecification()
        {
            DisplayName = "ReportSpecification";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Required")]
    [Name("Required")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosRequired : ClassificationFormatDefinition
    {
        public RhetosRequired()
        {
            DisplayName = "Required";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "RequiredClaim")]
    [Name("RequiredClaim")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosRequiredClaim : ClassificationFormatDefinition
    {
        public RhetosRequiredClaim()
        {
            DisplayName = "RequiredClaim";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Shortcut")]
    [Name("Shortcut")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosShortcut : ClassificationFormatDefinition
    {
        public RhetosShortcut()
        {
            DisplayName = "Shortcut";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "ShortString")]
    [Name("ShortString")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosShortString : ClassificationFormatDefinition
    {
        public RhetosShortString()
        {
            DisplayName = "ShortString";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "SingleRoot")]
    [Name("SingleRoot")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosSingleRoot : ClassificationFormatDefinition
    {
        public RhetosSingleRoot()
        {
            DisplayName = "SingleRoot";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "SqlDefault")]
    [Name("SqlDefault")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosSqlDefault : ClassificationFormatDefinition
    {
        public RhetosSqlDefault()
        {
            DisplayName = "SqlDefault";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "SqlDependsOn")]
    [Name("SqlDependsOn")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosSqlDependsOn : ClassificationFormatDefinition
    {
        public RhetosSqlDependsOn()
        {
            DisplayName = "SqlDependsOn";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "SqlDependsOnFunction")]
    [Name("SqlDependsOnFunction")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosSqlDependsOnFunction : ClassificationFormatDefinition
    {
        public RhetosSqlDependsOnFunction()
        {
            DisplayName = "SqlDependsOnFunction";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "SqlDependsOnSqlObject")]
    [Name("SqlDependsOnSqlObject")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosSqlDependsOnSqlObject : ClassificationFormatDefinition
    {
        public RhetosSqlDependsOnSqlObject()
        {
            DisplayName = "SqlDependsOnSqlObject";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "SqlDependsOnView")]
    [Name("SqlDependsOnView")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosSqlDependsOnView : ClassificationFormatDefinition
    {
        public RhetosSqlDependsOnView()
        {
            DisplayName = "SqlDependsOnView";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "SqlFunction")]
    [Name("SqlFunction")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosSqlFunction : ClassificationFormatDefinition
    {
        public RhetosSqlFunction()
        {
            DisplayName = "SqlFunction";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "SqlIndex")]
    [Name("SqlIndex")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosSqlIndex : ClassificationFormatDefinition
    {
        public RhetosSqlIndex()
        {
            DisplayName = "SqlIndex";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "SqlIndexMultiple")]
    [Name("SqlIndexMultiple")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosSqlIndexMultiple : ClassificationFormatDefinition
    {
        public RhetosSqlIndexMultiple()
        {
            DisplayName = "SqlIndexMultiple";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "SqlObject")]
    [Name("SqlObject")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosSqlObject : ClassificationFormatDefinition
    {
        public RhetosSqlObject()
        {
            DisplayName = "SqlObject";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "SqlProcedure")]
    [Name("SqlProcedure")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosSqlProcedure : ClassificationFormatDefinition
    {
        public RhetosSqlProcedure()
        {
            DisplayName = "SqlProcedure";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "SqlQueryable")]
    [Name("SqlQueryable")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosSqlQueryable : ClassificationFormatDefinition
    {
        public RhetosSqlQueryable()
        {
            DisplayName = "SqlQueryable";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "SqlTrigger")]
    [Name("SqlTrigger")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosSqlTrigger : ClassificationFormatDefinition
    {
        public RhetosSqlTrigger()
        {
            DisplayName = "SqlTrigger";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "SqlView")]
    [Name("SqlView")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosSqlView : ClassificationFormatDefinition
    {
        public RhetosSqlView()
        {
            DisplayName = "SqlView";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "TemplaterReport")]
    [Name("TemplaterReport")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosTemplaterReport : ClassificationFormatDefinition
    {
        public RhetosTemplaterReport()
        {
            DisplayName = "TemplaterReport";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Unique")]
    [Name("Unique")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosUnique : ClassificationFormatDefinition
    {
        public RhetosUnique()
        {
            DisplayName = "Unique";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "UniqueMultiple")]
    [Name("UniqueMultiple")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosUniqueMultiple : ClassificationFormatDefinition
    {
        public RhetosUniqueMultiple()
        {
            DisplayName = "UniqueMultiple";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "UseExecutionContext")]
    [Name("UseExecutionContext")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosUseExecutionContext : ClassificationFormatDefinition
    {
        public RhetosUseExecutionContext()
        {
            DisplayName = "UseExecutionContext";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "ValidationMenuItem")]
    [Name("ValidationMenuItem")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosValidationMenuItem : ClassificationFormatDefinition
    {
        public RhetosValidationMenuItem()
        {
            DisplayName = "ValidationMenuItem";
            ForegroundColor = Colors.Green;
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Browse")]
    [Name("Browse")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosBrowse : ClassificationFormatDefinition
    {
        public RhetosBrowse()
        {
            DisplayName = "Browse";
            ForegroundColor = Colors.Green;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Browseable")]
    [Name("Browseable")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosBrowseable : ClassificationFormatDefinition
    {
        public RhetosBrowseable()
        {
            DisplayName = "Browseable";
            ForegroundColor = Colors.Green;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "SmartSearch")]
    [Name("SmartSearch")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class RhetosSmartSearch : ClassificationFormatDefinition
    {
        public RhetosSmartSearch()
        {
            DisplayName = "SmartSearch";
            ForegroundColor = Colors.Green;
        }
    }
}
