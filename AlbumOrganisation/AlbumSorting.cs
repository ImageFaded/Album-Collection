﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumOrganisation
{
    static class AlbumSorting
    {       
        static public string SearchArtistAccess(TextBox textList)
        {
            return SearchArtist(textList);
        }

        static private string SearchArtist(TextBox textList)
        {
            //MessageBox.Show("Search Artist");
            return "Search Artist!\n";
        }

        static public string SearchAlbumAccess(TextBox textList)
        {
            return SearchAlbum(textList);
        }

        static private string SearchAlbum(TextBox textList)
        {
            return "Search Album!\n";
            //MessageBox.Show("Search Album");
        }

        static public string AddAccess(TextBox textList)
        {
            return AddAlbum(textList);
        }

        static private string AddAlbum(TextBox textList)
        {
            return "Add Album!\n";
            //MessageBox.Show("Add Album");
        }

        static public string RemoveAccess(TextBox textList)
        {
            return RemoveAlbum(textList);
        }

        static private string RemoveAlbum(TextBox textList)
        {
            return "Remove Album!\n";
            //MessageBox.Show("Remove Album");
        }
    }
}
