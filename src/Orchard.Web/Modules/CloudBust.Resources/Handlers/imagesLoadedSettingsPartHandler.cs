﻿using CloudBust.Resources.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.Environment.Extensions;
using Orchard.Localization;

namespace CloudBust.Resources.Handlers
{
    [OrchardFeature("CloudBust.Resources.ImagesLoaded")]
    public class ImagesLoadedSettingsPartHandler: ContentHandler {
        public ImagesLoadedSettingsPartHandler(IRepository<ImagesLoadedSettingsPartRecord> repository)
        {
            T = NullLocalizer.Instance;
            Filters.Add(StorageFilter.For(repository));
            Filters.Add(new ActivatingFilter<ImagesLoadedSettingsPart>("Site"));

            OnInitializing<ImagesLoadedSettingsPart>((context, part) =>
            {
                part.AutoEnable = true;
                part.AutoEnableAdmin = true;
            });
        }

        public Localizer T { get; set; }

        protected override void GetItemMetadata(GetContentItemMetadataContext context) {
            if (context.ContentItem.ContentType != "Site")
                return;
            base.GetItemMetadata(context);
            context.Metadata.EditorGroupInfo.Add(new GroupInfo(T("ImagesLoaded")));
        }
    }
}