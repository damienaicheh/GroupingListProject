using GroupingListProject.Helpers;
using GroupingListProject.Models;
using GroupingListProject.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace GroupingListProject.ViewModels
{
    public class MyViewModel
    {
        private ObservableCollection<GroupInfosList> _players = new ObservableCollection<GroupInfosList>();
        public ObservableCollection<GroupInfosList> Players {
            get { return _players; }
            set { value = _players; }
        }

        public void Initialize()
        {
            PlayerService playerService = new PlayerService();
            var data = playerService.GetData();
            GeneratePanierByStatusGroup(data);                
        }
       
        public void GeneratePanierByStatusGroup(List<Player> players)
        {
            var query = from item in players
                        group item by item.Position into g
                        orderby g.Key
                        select new { GroupName = g.Key, Items = g };

            foreach (var g in query)
            {
                GroupInfosList info = new GroupInfosList();
                info.Key = g.GroupName + " (" + g.Items.Count() + ")" ;

                foreach (var item in g.Items)
                {
                    info.Add(item);
                }

                Players.Add(info);
            }
        }

    }
}
