﻿// Decompiled with JetBrains decompiler
// Type: Gtk.DragTargetType
// Assembly: CocoStudio.Gtk.Extend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DBDD1FAC-46EB-4E25-BF62-EB35EC7EDA10
// Assembly location: C:\Program Files (x86)\Cocos\Cocos Studio 2\CocoStudio.Gtk.Extend.dll

namespace Gtk
{
  public static class DragTargetType
  {
    public static readonly TargetEntry CocoStudioTarget = new TargetEntry("application/CocoStudio", TargetFlags.App, 0U);
    public static readonly TargetEntry FileDropTarget = new TargetEntry("text/uri-list", (TargetFlags) 0, 0U);
  }
}
