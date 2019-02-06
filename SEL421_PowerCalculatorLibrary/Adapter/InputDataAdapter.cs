using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEL421_PowerCalculator.Model.SEL421;

namespace SEL421_PowerCalculator.Adapter
{
    public class InputDataAdapter
    {
        #region [ Private Members ]
        private double m_IAWPM;
        private double m_IAWPA;
        private double m_IBWPM;
        private double m_IBWPA;
        private double m_ICWPM;
        private double m_ICWPA;
        private double m_IAXPM;
        private double m_IAXPA;
        private double m_IBXPM;
        private double m_IBXPA;
        private double m_ICXPM;
        private double m_ICXPA;

        private double m_VAYPM;
        private double m_VAYPA;
        private double m_VBYPM;
        private double m_VBYPA;
        private double m_VCYPM;
        private double m_VCYPA;
        private double m_VAZPM;
        private double m_VAZPA;
        private double m_VBZPM;
        private double m_VBZPA;
        private double m_VCZPM;
        private double m_VCZPA;
        #endregion

        #region [ Public Properties ]

        public double IAWPM
        {
            get
            {
                return m_IAWPM;
            }
            set
            {
                m_IAWPM = value;
            }
        }

        public double IAWPA
        {
            get
            {
                return m_IAWPA;
            }
            set
            {
                m_IAWPA = value;
            }
        }

        public double IBWPM
        {
            get
            {
                return m_IBWPM;
            }
            set
            {
                m_IBWPM = value;
            }
        }

        public double IBWPA
        {
            get
            {
                return m_IBWPA;
            }
            set
            {
                m_IBWPA = value;
            }
        }

        public double ICWPM
        {
            get
            {
                return m_ICWPM;
            }
            set
            {
                m_ICWPM = value;
            }
        }

        public double ICWPA
        {
            get
            {
                return m_ICWPA;
            }
            set
            {
                m_ICWPA = value;
            }
        }

        public double IAXPM
        {
            get
            {
                return m_IAXPM;
            }
            set
            {
                m_IAXPM = value;
            }
        }

        public double IAXPA
        {
            get
            {
                return m_IAXPA;
            }
            set
            {
                m_IAXPA = value;
            }
        }

        public double IBXPM
        {
            get
            {
                return m_IBXPM;
            }
            set
            {
                m_IBXPM = value;
            }
        }

        public double IBXPA
        {
            get
            {
                return m_IBXPA;
            }
            set
            {
                m_IBXPA = value;
            }
        }

        public double ICXPM
        {
            get
            {
                return m_ICXPM;
            }
            set
            {
                m_ICXPM = value;
            }
        }

        public double ICXPA
        {
            get
            {
                return m_ICXPA;
            }
            set
            {
                m_ICXPA = value;
            }
        }

        public double VAYPM
        {
            get
            {
                return m_VAYPM;
            }
            set
            {
                m_VAYPM = value;
            }
        }

        public double VAYPA
        {
            get
            {
                return m_VAYPA;
            }
            set
            {
                m_VAYPA = value;
            }
        }

        public double VBYPM
        {
            get
            {
                return m_VBYPM;
            }
            set
            {
                m_VBYPM = value;
            }
        }

        public double VBYPA
        {
            get
            {
                return m_VBYPA;
            }
            set
            {
                m_VBYPA = value;
            }
        }

        public double VCYPM
        {
            get
            {
                return m_VCYPM;
            }
            set
            {
                m_VCYPM = value;
            }
        }

        public double VCYPA
        {
            get
            {
                return m_VCYPA;
            }
            set
            {
                m_VCYPA = value;
            }
        }

        public double VAZPM
        {
            get
            {
                return m_VAZPM;
            }
            set
            {
                m_VAZPM = value;
            }
        }

        public double VAZPA
        {
            get
            {
                return m_VAZPA;
            }
            set
            {
                m_VAZPA = value;
            }
        }

        public double VBZPM
        {
            get
            {
                return m_VBZPM;
            }
            set
            {
                m_VBZPM = value;
            }
        }

        public double VBZPA
        {
            get
            {
                return m_VBZPA;
            }
            set
            {
                m_VBZPA = value;
            }
        }

        public double VCZPM
        {
            get
            {
                return m_VCZPM;
            }
            set
            {
                m_VCZPM = value;
            }
        }

        public double VCZPA
        {
            get
            {
                return m_VCZPA;
            }
            set
            {
                m_VCZPA = value;
            }
        }

        #endregion

        #region [ Constructor ]
        public InputDataAdapter()
        {
            m_IAWPM = 0;
            m_IAWPA = 0;
            m_IBWPM = 0;
            m_IBWPA = 0;
            m_ICWPM = 0;
            m_ICWPA = 0;
            m_IAXPM = 0;
            m_IAXPA = 0;
            m_IBXPM = 0;
            m_IBXPA = 0;
            m_ICXPM = 0;
            m_ICXPA = 0;

            m_VAYPM = 0;
            m_VAYPA = 0;
            m_VBYPM = 0;
            m_VBYPA = 0;
            m_VCYPM = 0;
            m_VCYPA = 0;
            m_VAZPM = 0;
            m_VAZPA = 0;
            m_VBZPM = 0;
            m_VBZPA = 0;
            m_VCZPM = 0;
            m_VCZPA = 0;

        }
        #endregion

        #region [ Public Methods ]

        public void ReadFromInputData(Inputs inputData)
        {
            m_IAWPM = inputData.IAWPM * 3.33333;
            m_IAWPA = inputData.IAWPA;
            m_IBWPM = inputData.IBWPM * 0.53333;
            m_IBWPA = inputData.IBWPA;
            m_ICWPM = inputData.ICWPM * 10;
            m_ICWPA = inputData.ICWPA;
            m_IAXPM = inputData.IAXPM * 6.66667;
            m_IAXPA = inputData.IAXPA;
            m_IBXPM = inputData.IBXPM * 6.66667;
            m_IBXPA = inputData.IBXPA;
            m_ICXPM = inputData.ICXPM * 1;
            m_ICXPA = inputData.ICXPA;
            m_VAYPM = inputData.VAYPM / 7.5;
            m_VAYPA = inputData.VAYPA;
            m_VBYPM = inputData.VBYPM / 7.5;
            m_VBYPA = inputData.VBYPA;
            m_VCYPM = inputData.VCYPM / 37.5;
            m_VCYPA = inputData.VCYPA;
            m_VAZPM = inputData.VAZPM / 37.5;
            m_VAZPA = inputData.VAZPA;
            m_VBZPM = inputData.VBZPM / 37.5;
            m_VBZPA = inputData.VBZPA;
            m_VCZPM = inputData.VCZPM / 1;
            m_VCZPA = inputData.VCZPA;

        }

        #endregion
    }
}
