// COMPILER GENERATED CODE
// THIS WILL BE OVERWRITTEN AT EACH GENERATION
// EDIT AT YOUR OWN RISK

using System;
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
    public class Unmapper : UnmapperBase
    {
        #region [ Constructors ]

        public Unmapper(Framework framework, MappingCompiler mappingCompiler)
            : base(framework, mappingCompiler, SystemSettings.OutputMapping)
        {
            Algorithm.Output.CreateNew = () => new Algorithm.Output()
            {
                OutputData = FillOutputData(),
                OutputMeta = FillOutputMeta()
            };
        }

        #endregion

        #region [ Methods ]

        public SEL421_PowerCalculator.Model.SEL421.Outputs FillOutputData()
        {
            TypeMapping outputMapping = MappingCompiler.GetTypeMapping(OutputMapping);
            Reset();
            return FillSEL421Outputs(outputMapping);
        }

        public SEL421_PowerCalculator.Model.SEL421._OutputsMeta FillOutputMeta()
        {
            TypeMapping outputMeta = MappingCompiler.GetTypeMapping(OutputMapping);
            Reset();
            return FillSEL421_OutputsMeta(outputMeta);
        }

        public IEnumerable<IMeasurement> Unmap(SEL421_PowerCalculator.Model.SEL421.Outputs outputData, SEL421_PowerCalculator.Model.SEL421._OutputsMeta outputMeta)
        {
            List<IMeasurement> measurements = new List<IMeasurement>();
            TypeMapping outputMapping = MappingCompiler.GetTypeMapping(OutputMapping);

            CollectFromSEL421Outputs(measurements, outputMapping, outputData, outputMeta);

            return measurements;
        }

        private SEL421_PowerCalculator.Model.SEL421.Outputs FillSEL421Outputs(TypeMapping typeMapping)
        {
            Dictionary<string, FieldMapping> fieldLookup = typeMapping.FieldMappings.ToDictionary(mapping => mapping.Field.Identifier);
            SEL421_PowerCalculator.Model.SEL421.Outputs obj = new SEL421_PowerCalculator.Model.SEL421.Outputs();

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            return obj;
        }

        private SEL421_PowerCalculator.Model.SEL421._OutputsMeta FillSEL421_OutputsMeta(TypeMapping typeMapping)
        {
            Dictionary<string, FieldMapping> fieldLookup = typeMapping.FieldMappings.ToDictionary(mapping => mapping.Field.Identifier);
            SEL421_PowerCalculator.Model.SEL421._OutputsMeta obj = new SEL421_PowerCalculator.Model.SEL421._OutputsMeta();

            {
                // Initialize meta value structure to "P1" field
                FieldMapping fieldMapping = fieldLookup["P1"];
                obj.P1 = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "Q1" field
                FieldMapping fieldMapping = fieldLookup["Q1"];
                obj.Q1 = CreateMetaValues(fieldMapping);
            }


            {
                // Initialize meta value structure to "P2" field
                FieldMapping fieldMapping = fieldLookup["P2"];
                obj.P2 = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "Q2" field
                FieldMapping fieldMapping = fieldLookup["Q2"];
                obj.Q2 = CreateMetaValues(fieldMapping);
            }
            {
                // Initialize meta value structure to "P3" field
                FieldMapping fieldMapping = fieldLookup["P3"];
                obj.P3 = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "Q3" field
                FieldMapping fieldMapping = fieldLookup["Q3"];
                obj.Q3 = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "P4" field
                FieldMapping fieldMapping = fieldLookup["P4"];
                obj.P4 = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "Q4" field
                FieldMapping fieldMapping = fieldLookup["Q4"];
                obj.Q4 = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "P5" field
                FieldMapping fieldMapping = fieldLookup["P5"];
                obj.P5 = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "Q5" field
                FieldMapping fieldMapping = fieldLookup["Q5"];
                obj.Q5 = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "P6" field
                FieldMapping fieldMapping = fieldLookup["P6"];
                obj.P6 = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "Q6" field
                FieldMapping fieldMapping = fieldLookup["Q6"];
                obj.Q6 = CreateMetaValues(fieldMapping);
            }

            return obj;
        }

        private void CollectFromSEL421Outputs(List<IMeasurement> measurements, TypeMapping typeMapping, SEL421_PowerCalculator.Model.SEL421.Outputs data, SEL421_PowerCalculator.Model.SEL421._OutputsMeta meta)
        {
            Dictionary<string, FieldMapping> fieldLookup = typeMapping.FieldMappings.ToDictionary(mapping => mapping.Field.Identifier);

            {
                // Convert value from "P1" field to measurement
                FieldMapping fieldMapping = fieldLookup["P1"];
                IMeasurement measurement = MakeMeasurement(meta.P1, (double)data.P1);
                measurements.Add(measurement);
            }

            {
                // Convert value from "P2" field to measurement
                FieldMapping fieldMapping = fieldLookup["P2"];
                IMeasurement measurement = MakeMeasurement(meta.P2, (double)data.P2);
                measurements.Add(measurement);
            }

            {
                // Convert value from "P3" field to measurement
                FieldMapping fieldMapping = fieldLookup["P3"];
                IMeasurement measurement = MakeMeasurement(meta.P3, (double)data.P3);
                measurements.Add(measurement);
            }

            {
                // Convert value from "P4" field to measurement
                FieldMapping fieldMapping = fieldLookup["P4"];
                IMeasurement measurement = MakeMeasurement(meta.P4, (double)data.P4);
                measurements.Add(measurement);
            }

            {
                // Convert value from "P5" field to measurement
                FieldMapping fieldMapping = fieldLookup["P5"];
                IMeasurement measurement = MakeMeasurement(meta.P5, (double)data.P5);
                measurements.Add(measurement);
            }

            {
                // Convert value from "P6" field to measurement
                FieldMapping fieldMapping = fieldLookup["P6"];
                IMeasurement measurement = MakeMeasurement(meta.P6, (double)data.P6);
                measurements.Add(measurement);
            }

            {
                // Convert value from "Q1" field to measurement
                FieldMapping fieldMapping = fieldLookup["Q1"];
                IMeasurement measurement = MakeMeasurement(meta.Q1, (double)data.Q1);
                measurements.Add(measurement);
            }

            {
                // Convert value from "Q2" field to measurement
                FieldMapping fieldMapping = fieldLookup["Q2"];
                IMeasurement measurement = MakeMeasurement(meta.Q2, (double)data.Q2);
                measurements.Add(measurement);
            }

            {
                // Convert value from "Q3" field to measurement
                FieldMapping fieldMapping = fieldLookup["Q3"];
                IMeasurement measurement = MakeMeasurement(meta.Q3, (double)data.Q3);
                measurements.Add(measurement);
            }

            {
                // Convert value from "Q4" field to measurement
                FieldMapping fieldMapping = fieldLookup["Q4"];
                IMeasurement measurement = MakeMeasurement(meta.Q4, (double)data.Q4);
                measurements.Add(measurement);
            }

            {
                // Convert value from "Q5" field to measurement
                FieldMapping fieldMapping = fieldLookup["Q5"];
                IMeasurement measurement = MakeMeasurement(meta.Q5, (double)data.Q5);
                measurements.Add(measurement);
            }

            {
                // Convert value from "Q6" field to measurement
                FieldMapping fieldMapping = fieldLookup["Q6"];
                IMeasurement measurement = MakeMeasurement(meta.Q6, (double)data.Q6);
                measurements.Add(measurement);
            }
        }

        #endregion
    }
}
