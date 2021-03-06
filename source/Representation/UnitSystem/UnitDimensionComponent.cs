﻿/*******************************************************************************
  * Copyright (C) 2015 AgGateway and ADAPT Contributors
  * Copyright (C) 2015 Deere and Company
  * All rights reserved. This program and the accompanying materials
  * are made available under the terms of the Eclipse Public License v1.0
  * which accompanies this distribution, and is available at
  * http://www.eclipse.org/legal/epl-v10.html <http://www.eclipse.org/legal/epl-v10.html> 
  *
  * Contributors:
  *    Justin Sliekers, Tim Shearouse - initial API and implementation
  *******************************************************************************/
namespace AgGateway.ADAPT.Representation.UnitSystem
{
    public class UnitDimensionComponent
    {
        public UnitDimensionComponent(string unitDimensionId, int power)
        {
            UnitDimensionDomainId = unitDimensionId;
            Power = power;
        }

        public string UnitDimensionDomainId{ get; private set; }

        public int Power { get; private set; }
    }
}
