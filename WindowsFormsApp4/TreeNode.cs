using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class TreeNode
    {
        private String Text;
        private int Node_ID;
        private int level;
        private TreeNode parent;
        private List<TreeNode> kids;

        public TreeNode(String name,int lev,TreeNode par,int id)
        {
            Text = name;
            Node_ID = id;
            level = lev;
            parent = par;
            kids = null;
        }

        public String ToString() {
            return Text;
        }

        public TreeNode(String name, int lev, int id)
        {
            Text = name;
            Node_ID = id;
            level = lev;
            parent = null;
            kids = null;
        }

        public TreeNode GetParent() {
            return parent;
            }

        public List<TreeNode> GetKids()
        {
            return kids;
        }

        public Boolean AddKid(TreeNode a_kid)
        {
            if (null != a_kid)
            {
                kids.Add(a_kid);
                return true;
            }
            else
                return false;
        }

        public Boolean SetParent(TreeNode par)
        {
            if (null != par)
            {
                parent = par;
                return true;
            }
            else
                return false;
        }

    }
}
