// COMPILER GENERATED CODE
// THIS WILL BE OVERWRITTEN AT EACH GENERATION
// EDIT AT YOUR OWN RISK

using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ECAClientFramework;
using ECAClientUtilities;
using ECACommonUtilities;
using ECACommonUtilities.Model;
using GSF.TimeSeries;

namespace SEL421_PowerCalculator.Model
{
    [CompilerGenerated]
    public class Mapper : MapperBase
    {
        #region [ Members ]

        // Fields
        private readonly Unmapper m_unmapper;

        #endregion

        #region [ Constructors ]

        public Mapper(Framework framework)
            : base(framework, SystemSettings.InputMapping)
        {
            m_unmapper = new Unmapper(framework, MappingCompiler);
            Unmapper = m_unmapper;
        }

        #endregion

        #region [ Methods ]

        public override void Map(IDictionary<MeasurementKey, IMeasurement> measurements)
        {
            SignalLookup.UpdateMeasurementLookup(measurements);
            TypeMapping inputMapping = MappingCompiler.GetTypeMapping(InputMapping);

            Reset();
            SEL421_PowerCalculator.Model.SEL421.Inputs inputData = CreateSEL421Inputs(inputMapping);
            Reset();
            SEL421_PowerCalculator.Model.SEL421._InputsMeta inputMeta = CreateSEL421_InputsMeta(inputMapping);

            Algorithm.Output algorithmOutput = Algorithm.Execute(inputData, inputMeta);
            Subscriber.SendMeasurements(m_unmapper.Unmap(algorithmOutput.OutputData, algorithmOutput.OutputMeta));
        }

        private SEL421_PowerCalculator.Model.SEL421.Inputs CreateSEL421Inputs(TypeMapping typeMapping)
        {
            Dictionary<string, FieldMapping> fieldLookup = typeMapping.FieldMappings.ToDictionary(mapping => mapping.Field.Identifier);
            SEL421_PowerCalculator.Model.SEL421.Inputs obj = new SEL421_PowerCalculator.Model.SEL421.Inputs();

            {
                // Assign double value to "IAWPM" field
                FieldMapping fieldMapping = fieldLookup["IAWPM"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.IAWPM = (double)measurement.Value;
            }

            {
                // Assign double value to "IAWPA" field
                FieldMapping fieldMapping = fieldLookup["IAWPA"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.IAWPA = (double)measurement.Value;
            }

            {
                // Assign double value to "IBWPM" field
                FieldMapping fieldMapping = fieldLookup["IBWPM"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.IBWPM = (double)measurement.Value;
            }

            {
                // Assign double value to "IBWPA" field
                FieldMapping fieldMapping = fieldLookup["IBWPA"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.IBWPA = (double)measurement.Value;
            }

            {
                // Assign double value to "ICWPM" field
                FieldMapping fieldMapping = fieldLookup["ICWPM"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.ICWPM = (double)measurement.Value;
            }

            {
                // Assign double value to "ICWPA" field
                FieldMapping fieldMapping = fieldLookup["ICWPA"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.ICWPA = (double)measurement.Value;
            }

            {
                // Assign double value to "IAXPM" field
                FieldMapping fieldMapping = fieldLookup["IAXPM"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.IAXPM = (double)measurement.Value;
            }

            {
                // Assign double value to "IAXPA" field
                FieldMapping fieldMapping = fieldLookup["IAXPA"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.IAXPA = (double)measurement.Value;
            }

            {
                // Assign double value to "IBXPM" field
                FieldMapping fieldMapping = fieldLookup["IBXPM"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.IBXPM = (double)measurement.Value;
            }

            {
                // Assign double value to "IBXPA" field
                FieldMapping fieldMapping = fieldLookup["IBXPA"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.IBXPA = (double)measurement.Value;
            }

            {
                // Assign double value to "ICXPM" field
                FieldMapping fieldMapping = fieldLookup["ICXPM"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.ICXPM = (double)measurement.Value;
            }

            {
                // Assign double value to "ICXPA" field
                FieldMapping fieldMapping = fieldLookup["ICXPA"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.ICXPA = (double)measurement.Value;
            }

            {
                // Assign double value to "VAYPM" field
                FieldMapping fieldMapping = fieldLookup["VAYPM"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VAYPM = (double)measurement.Value;
            }

            {
                // Assign double value to "VAYPA" field
                FieldMapping fieldMapping = fieldLookup["VAYPA"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VAYPA = (double)measurement.Value;
            }

            {
                // Assign double value to "VBYPM" field
                FieldMapping fieldMapping = fieldLookup["VBYPM"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VBYPM = (double)measurement.Value;
            }

            {
                // Assign double value to "VBYPA" field
                FieldMapping fieldMapping = fieldLookup["VBYPA"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VBYPA = (double)measurement.Value;
            }

            {
                // Assign double value to "VCYPM" field
                FieldMapping fieldMapping = fieldLookup["VCYPM"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VCYPM = (double)measurement.Value;
            }

            {
                // Assign double value to "VCYPA" field
                FieldMapping fieldMapping = fieldLookup["VCYPA"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VCYPA = (double)measurement.Value;
            }

            {
                // Assign double value to "VAZPM" field
                FieldMapping fieldMapping = fieldLookup["VAZPM"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VAZPM = (double)measurement.Value;
            }

            {
                // Assign double value to "VAZPA" field
                FieldMapping fieldMapping = fieldLookup["VAZPA"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VAZPA = (double)measurement.Value;
            }

            {
                // Assign double value to "VBZPM" field
                FieldMapping fieldMapping = fieldLookup["VBZPM"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VBZPM = (double)measurement.Value;
            }

            {
                // Assign double value to "VBZPA" field
                FieldMapping fieldMapping = fieldLookup["VBZPA"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VBZPA = (double)measurement.Value;
            }

            {
                // Assign double value to "VCZPM" field
                FieldMapping fieldMapping = fieldLookup["VCZPM"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VCZPM = (double)measurement.Value;
            }

            {
                // Assign double value to "VCZPA" field
                FieldMapping fieldMapping = fieldLookup["VCZPA"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VCZPA = (double)measurement.Value;
            }

            return obj;
        }

        private SEL421_PowerCalculator.Model.SEL421._InputsMeta CreateSEL421_InputsMeta(TypeMapping typeMapping)
        {
            Dictionary<string, FieldMapping> fieldLookup = typeMapping.FieldMappings.ToDictionary(mapping => mapping.Field.Identifier);
            SEL421_PowerCalculator.Model.SEL421._InputsMeta obj = new SEL421_PowerCalculator.Model.SEL421._InputsMeta();

            {
                // Assign MetaValues value to "IAWPM" field
                FieldMapping fieldMapping = fieldLookup["IAWPM"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.IAWPM = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "IAWPA" field
                FieldMapping fieldMapping = fieldLookup["IAWPA"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.IAWPA = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "IBWPM" field
                FieldMapping fieldMapping = fieldLookup["IBWPM"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.IBWPM = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "IBWPA" field
                FieldMapping fieldMapping = fieldLookup["IBWPA"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.IBWPA = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "ICWPM" field
                FieldMapping fieldMapping = fieldLookup["ICWPM"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.ICWPM = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "ICWPA" field
                FieldMapping fieldMapping = fieldLookup["ICWPA"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.ICWPA = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "IAXPM" field
                FieldMapping fieldMapping = fieldLookup["IAXPM"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.IAXPM = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "IAXPA" field
                FieldMapping fieldMapping = fieldLookup["IAXPA"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.IAXPA = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "IBXPM" field
                FieldMapping fieldMapping = fieldLookup["IBXPM"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.IBXPM = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "IBXPA" field
                FieldMapping fieldMapping = fieldLookup["IBXPA"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.IBXPA = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "ICXPM" field
                FieldMapping fieldMapping = fieldLookup["ICXPM"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.ICXPM = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "ICXPA" field
                FieldMapping fieldMapping = fieldLookup["ICXPA"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.ICXPA = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "VAYPM" field
                FieldMapping fieldMapping = fieldLookup["VAYPM"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VAYPM = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "VAYPA" field
                FieldMapping fieldMapping = fieldLookup["VAYPA"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VAYPA = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "VBYPM" field
                FieldMapping fieldMapping = fieldLookup["VBYPM"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VBYPM = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "VBYPA" field
                FieldMapping fieldMapping = fieldLookup["VBYPA"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VBYPA = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "VCYPM" field
                FieldMapping fieldMapping = fieldLookup["VCYPM"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VCYPM = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "VCYPA" field
                FieldMapping fieldMapping = fieldLookup["VCYPA"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VCYPA = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "VAZPM" field
                FieldMapping fieldMapping = fieldLookup["VAZPM"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VAZPM = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "VAZPA" field
                FieldMapping fieldMapping = fieldLookup["VAZPA"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VAZPA = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "VBZPM" field
                FieldMapping fieldMapping = fieldLookup["VBZPM"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VBZPM = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "VBZPA" field
                FieldMapping fieldMapping = fieldLookup["VBZPA"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VBZPA = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "VCZPM" field
                FieldMapping fieldMapping = fieldLookup["VCZPM"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VCZPM = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "VCZPA" field
                FieldMapping fieldMapping = fieldLookup["VCZPA"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.VCZPA = GetMetaValues(measurement);
            }

            return obj;
        }

        #endregion
    }
}
