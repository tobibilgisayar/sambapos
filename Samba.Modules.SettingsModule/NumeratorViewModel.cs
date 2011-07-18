﻿using System;
using Samba.Domain.Models.Settings;
using Samba.Infrastructure;
using Samba.Infrastructure.Data;
using Samba.Presentation.Common.ModelBase;

namespace Samba.Modules.SettingsModule
{
    public class NumeratorViewModel : EntityViewModelBase<Numerator>
    {
        public string NumberFormat
        {
            get { return Model.NumberFormat; }
            set { Model.NumberFormat = value; }
        }

        public NumeratorViewModel(Numerator model)
            : base(model)
        {
        }

        public override Type GetViewType()
        {
            return typeof(NumeratorView);
        }

        public override string GetModelTypeString()
        {
            return "Numaratör";
        }

        public override void Initialize(IWorkspace workspace)
        {

        }
    }
}
