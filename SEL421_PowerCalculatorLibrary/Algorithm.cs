using System;
using System.Text;
using ECAClientFramework;
using ECAClientUtilities.API;
using SEL421_PowerCalculator.Adapter;
using SEL421_PowerCalculator.Model.SEL421;

namespace SEL421_PowerCalculator
{
    public static class Algorithm
    {
        public static Hub API { get; set; }

        internal class Output
        {
            public Outputs OutputData = new Outputs();
            public _OutputsMeta OutputMeta = new _OutputsMeta();
            public static Func<Output> CreateNew { get; set; } = () => new Output();
        }

        public static void UpdateSystemSettings()
        {
            SystemSettings.InputMapping = "SEL421_InputMapping";
            SystemSettings.OutputMapping = "SEL421_OutputMapping";
            SystemSettings.ConnectionString = @"server=localhost:6190; interface=0.0.0.0";
            SystemSettings.FramesPerSecond = 4;
            SystemSettings.LagTime = 3;
            SystemSettings.LeadTime = 1;
        }

        internal static Output Execute(Inputs inputData, _InputsMeta inputMeta)
        {
            Output output = Output.CreateNew();

            try
            {
                // TODO: Implement your algorithm here...
                // You can also write messages to the main window:

                //Inputs m_input = inputData;
                InputDataAdapter m_input = new InputDataAdapter();
                m_input.ReadFromInputData(inputData);

                output.OutputData.P1 = 3 * m_input.VAYPM * m_input.IAWPM * Math.Cos((m_input.VAYPA - m_input.IAWPA) / 180 * Math.PI);
                output.OutputData.Q1 = 3 * m_input.VAYPM * m_input.IAWPM * Math.Sin((m_input.VAYPA - m_input.IAWPA) / 180 * Math.PI);

                output.OutputData.P2 = 3 * m_input.VBYPM * m_input.IBWPM * Math.Cos((m_input.VBYPA - m_input.IBWPA) / 180 * Math.PI);
                output.OutputData.Q2 = 3 * m_input.VBYPM * m_input.IBWPM * Math.Sin((m_input.VBYPA - m_input.IBWPA) / 180 * Math.PI);

                output.OutputData.P3 = 3 * m_input.VAZPM * m_input.ICWPM * Math.Cos((m_input.VAZPA - m_input.ICWPA) / 180 * Math.PI);
                output.OutputData.Q3 = 3 * m_input.VAZPM * m_input.ICWPM * Math.Sin((m_input.VAZPA - m_input.ICWPA) / 180 * Math.PI);

                output.OutputData.P4 = 3 * m_input.VBZPM * m_input.IAXPM * Math.Cos((m_input.VBZPA - m_input.IAXPA) / 180 * Math.PI);
                output.OutputData.Q4 = 3 * m_input.VBZPM * m_input.IAXPM * Math.Sin((m_input.VBZPA - m_input.IAXPA) / 180 * Math.PI);

                //output.OutputData.P5 = 3 * m_input.VAYPM * m_input.IAWPM * Math.Cos((m_input.VAYPA - m_input.IAWPA) / 180 * Math.PI);
                //output.OutputData.Q5 = 3 * m_input.VAYPM * m_input.IAWPM * Math.Sin((m_input.VAYPA - m_input.IAWPA) / 180 * Math.PI);

                //output.OutputData.P6 = 3 * m_input.VAYPM * m_input.IAWPM * Math.Cos((m_input.VAYPA - m_input.IAWPA) / 180 * Math.PI);
                //output.OutputData.Q6 = 3 * m_input.VAYPM * m_input.IAWPM * Math.Sin((m_input.VAYPA - m_input.IAWPA) / 180 * Math.PI);

                StringBuilder _msg = new StringBuilder();
                _msg.AppendLine($" ================ SEL421_PowerCalculator ================");
                _msg.AppendLine($"                 VAY         VBY         VCY");
                _msg.AppendLine($"MAG(kV)  |  {inputData.VAYPM: 000.000}    {inputData.VBYPM: 000.000}    {inputData.VCYPM: 000.000} ");
                _msg.AppendLine($"ANG(deg) |  {inputData.VAYPA: 000.00}    {inputData.VBYPA: 000.00}    {inputData.VCYPA: 000.00} ");
                _msg.AppendLine($"         |       VAZ         VBZ         VCZ");
                _msg.AppendLine($"MAG(kV)  |  {inputData.VAZPM: 000.000}    {inputData.VBZPM: 000.000}    {inputData.VCZPM: 000.000} ");
                _msg.AppendLine($"ANG(deg) |  {inputData.VAZPA: 000.00}    {inputData.VBZPA: 000.00}    {inputData.VCZPA: 000.00} ");
                _msg.AppendLine($"         |       IAW         IBW         ICW");
                _msg.AppendLine($"MAG(kV)  |  {inputData.IAWPM: 000.000}    {inputData.IBWPM: 000.000}    {inputData.ICWPM: 000.000} ");
                _msg.AppendLine($"ANG(deg) |  {inputData.IAWPA: 000.00}    {inputData.IBWPA: 000.00}    {inputData.ICWPA: 000.00} ");
                _msg.AppendLine($"         |       IAX         IBX         ICX");
                _msg.AppendLine($"MAG(kV)  |  {inputData.IAXPM: 000.000}    {inputData.IBXPM: 000.000}    {inputData.ICXPM: 000.000} ");
                _msg.AppendLine($"ANG(deg) |  {inputData.IAXPA: 000.00}    {inputData.IBXPA: 000.00}    {inputData.ICXPA: 000.00} ");

                _msg.AppendLine($"                  MW        MVAR");
                _msg.AppendLine($"PQ1      | {output.OutputData.P1: 000.000}    {output.OutputData.Q1: 000.000}");
                _msg.AppendLine($"PQ2      | {output.OutputData.P2: 000.000}    {output.OutputData.Q2: 000.000}");
                _msg.AppendLine($"PQ3      | {output.OutputData.P3: 000.000}    {output.OutputData.Q3: 000.000}");
                _msg.AppendLine($"PQ4      | {output.OutputData.P4: 000.000}    {output.OutputData.Q4: 000.000}");
                _msg.AppendLine($"PQ5      | {output.OutputData.P5: 000.000}    {output.OutputData.Q5: 000.000}");
                _msg.AppendLine($"PQ6      | {output.OutputData.P6: 000.000}    {output.OutputData.Q6: 000.000}");

                //MainWindow.WriteMessage(_msg.ToString());

            }
            catch (Exception ex)
            {
                // Display exceptions to the main window
                MainWindow.WriteError(new InvalidOperationException($"Algorithm exception: {ex.Message}", ex));
            }

            return output;
        }
    }
}
