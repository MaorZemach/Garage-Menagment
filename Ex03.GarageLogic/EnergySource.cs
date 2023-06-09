﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class EnergySource
    {
        private float m_AmountOfEnergyLeftInPercentage; // protected?
        private readonly float m_MaxAmountOfEnergySource;
        private float m_CurrentAmountOfEnergySource;

        //public abstract void RenewAmountOfEnergy(float i_TimeToAddInHours);

        // protected readonly float m_MaxAmountOfEnergySource;
        // protected float m_CurrentAmountOfEnergySource;
        //  private const int k_MinAmountOfEnergySource = 0;

        protected EnergySource(float i_MaxAmountOfEnergySource, float i_CapacityLeftInEnergySource)
        {
            m_MaxAmountOfEnergySource = i_MaxAmountOfEnergySource;
            setAmountOfEnergyPrecentage(i_MaxAmountOfEnergySource, i_CapacityLeftInEnergySource);
            m_CurrentAmountOfEnergySource = i_CapacityLeftInEnergySource;
        }

        public float CurrentAmountOfEnergySource
        {
            get
            {
                return m_CurrentAmountOfEnergySource;
            }
            set
            {
                m_CurrentAmountOfEnergySource = value;
            }
        }

        public float AmountOfEnergyLeftInPercentage
        {
            get
            {
                return m_AmountOfEnergyLeftInPercentage;
            }

            set
            {
                m_AmountOfEnergyLeftInPercentage = value;
            }
        }

        public float MaxAmountOfEnergySource
        {
            get
            {
                return m_MaxAmountOfEnergySource;
            }
        }


        public float EnergyLeftInPercentage
        {
            get
            {
                return m_AmountOfEnergyLeftInPercentage;
            }
        }

        public void setAmountOfEnergyPrecentage(float i_MaxAmountOfEnergySource, float i_CapacityLeftInEnergySource)
        {
            m_AmountOfEnergyLeftInPercentage = (i_CapacityLeftInEnergySource / i_MaxAmountOfEnergySource) * 100;
        }
        public  void RenewAmountOfEnergy(float i_EnergySourceToAdd)
        {
            if ((m_CurrentAmountOfEnergySource + i_EnergySourceToAdd) > m_MaxAmountOfEnergySource)
            {
                
                throw new ValueOutOfRangeException("Invalid input. The value after addition is out of range.", 0, m_MaxAmountOfEnergySource);
            }
            else
            {
                m_CurrentAmountOfEnergySource += i_EnergySourceToAdd;
            }

        }
        /* public void ChargeOrRefuelVehicle(float i_AmountToCharge)
         {
             if (i_AmountToCharge < 0)
             {
                 throw new ValueOutOfRangeException("Error, The entered energy source number is negative.", k_MinAmountOfEnergySource, m_MaxAmountOfEnergySource);
             }
             else if (i_AmountToCharge + m_CurrentAmountOfEnergySource > m_MaxAmountOfEnergySource)
             {
                 throw new ValueOutOfRangeException("Error, The addition amount you wish to add is more then allowed.", k_MinAmountOfEnergySource, m_MaxAmountOfEnergySource);
             }
             else
             {
                 m_CurrentAmountOfEnergySource += i_AmountToCharge;
             }
         }
         */
    }
}