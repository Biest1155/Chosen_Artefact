﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Chosen_Artefact.Models;

namespace Chosen_Artefact
{
    class ArtefactAdapter : BaseAdapter<Artefact>
    {
        Activity activity;
        List<Artefact> artefacts;
        
        public ArtefactAdapter(Activity activity, List<Artefact> artefact)
        {
            this.activity = activity;
            this.artefacts = artefact;
        }

        public override Artefact this[int position]
        {
            get { return artefacts[position]; }
        }

        public override int Count
        {
            get { return artefacts.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = artefacts[position];
            View view = convertView;
            if (view == null) // no view to re-use, create new
                view = activity.LayoutInflater.Inflate(Resource.Layout.artefact_list_layout, null);
            view.FindViewById<TextView>(Resource.Id.artefact_name_list).Text = item.Name.ToString();
            view.FindViewById<TextView>(Resource.Id.type_list).Text = item.Type;
            view.FindViewById<TextView>(Resource.Id.element_list).Text = item.Element;

            view.FindViewById<TextView>(Resource.Id.artefact_name_list).SetTextColor(Android.Graphics.Color.Black);
            view.FindViewById<TextView>(Resource.Id.type_list).SetTextColor(Android.Graphics.Color.Black);
            view.FindViewById<TextView>(Resource.Id.element_list).SetTextColor(Android.Graphics.Color.Black);
            return view;
        }
    }
}