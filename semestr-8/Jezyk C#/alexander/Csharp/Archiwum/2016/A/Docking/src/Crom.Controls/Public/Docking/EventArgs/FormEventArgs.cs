/***************************************************************************
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
using System.Drawing;
using System.Windows.Forms;

namespace Crom.Controls.Docking
{
   /// <summary>
   /// Form event args
   /// </summary>
   public class FormEventArgs : EventArgs
   {
      #region Fields

      private Form         _form        = null;

      #endregion Fields

      #region Instance

      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="form">form</param>
      public FormEventArgs(Form form)
      {
         _form  = form;
      }

      #endregion Instance

      #region Public section

      /// <summary>
      /// Accessor of the form
      /// </summary>
      public Form Form
      {
         get { return _form; }
      }

      #endregion Public section
   }
}
