﻿/***************************************************************************
 *   CopyRight (C) 2009 by Cristinel Mazarine                              *
 *   Author:   Cristinel Mazarine                                          *
 *   Contact:  cristinel@osec.ro                                           *
 *                                                                         *
 *   This program is free software; you can redistribute it and/or modify  *
 *   it under the terms of the Crom Free License as published by           *
 *   the SC Crom-Osec SRL; version 1 of the License                        *
 *                                                                         *
 *   This program is distributed in the hope that it will be useful,       *
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of        *
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the         *
 *   Crom Free License for more details.                                   *
 *                                                                         *
 *   You should have received a copy of the Crom Free License along with   *
 *   this program; if not, write to the contact@osec.ro                    *
 ***************************************************************************/

using System;
using System.Windows.Forms;

namespace Crom.Controls.Docking
{
   /// <summary>
   /// Forms container control
   /// </summary>
   internal class FormsContainer : Control
   {
      #region Instance

      /// <summary>
      /// Default constructor
      /// </summary>
      public FormsContainer()
      {
      }

      #endregion Instance

      #region Protected section

      /// <summary>
      /// Creates the control collection instance
      /// </summary>
      /// <returns>collection</returns>
      protected override ControlCollection CreateControlsInstance()
      {
         return new FormsContainerControlCollection(this);
      }

      #endregion Protected section
   }
}
