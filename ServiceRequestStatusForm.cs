using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class ServiceRequestStatusForm : Form
    {
        public ServiceRequestStatusForm()
        {
            InitializeComponent();
            cmbStatus.Items.AddRange(new object[]
            {
                "Submitted",
                "In Progress",
                "Completed"
            });

            cmbStatus.SelectedIndex = 0;
            LoadRequests();
        }
        private void LoadRequests()
        {
            dgvRequests.DataSource = null;

            dgvRequests.DataSource = IssueManager.ReportedIssues
                .Select(issue => new
                {
                    issue.RequestId,
                    issue.Location,
                    issue.Category,
                    issue.DateReported,
                    issue.Status
                })
                .ToList();

            dgvRequests.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            lblRequestCount.Text =
                "Total requests: " +
                IssueManager.ReportedIssues.Count;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchId = txtRequestId.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchId))
            {
                LoadRequests();
                return;
            }

            RequestSearchTree searchTree = new RequestSearchTree();

            foreach (Issue issue in IssueManager.ReportedIssues)
            {
                searchTree.Insert(issue);
            }

            Issue matchingIssue = searchTree.Search(searchId);

            if (matchingIssue == null)
            {
                dgvRequests.DataSource = null;

                MessageBox.Show(
                    "No service request was found with that ID.",
                    "Request Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            dgvRequests.DataSource = null;

            dgvRequests.DataSource = new[]
            {
        new
        {
            matchingIssue.RequestId,
            matchingIssue.Location,
            matchingIssue.Category,
            matchingIssue.DateReported,
            matchingIssue.Status
        }
            };

            dgvRequests.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            lblRequestCount.Text = "Matching requests: 1";
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtRequestId.Clear();
            LoadRequests();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRequestId_TextChanged(object sender, EventArgs e)
        {

        }
        private void dgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dgvRequests.CurrentRow == null ||
                dgvRequests.CurrentRow.Cells["RequestId"].Value == null)
            {
                MessageBox.Show(
                    "Please select a service request first.",
                    "No Request Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a status.",
                    "Status Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string requestId = dgvRequests.CurrentRow
                .Cells["RequestId"].Value.ToString();

            Issue selectedIssue = IssueManager.ReportedIssues
                .FirstOrDefault(issue => issue.RequestId == requestId);

            if (selectedIssue == null)
            {
                MessageBox.Show("The selected request could not be found.");
                LoadRequests();
                return;
            }

            selectedIssue.Status = cmbStatus.SelectedItem.ToString();

            LoadRequests();

            MessageBox.Show(
                "The request status has been updated.",
                "Status Updated",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnPrioritise_Click(object sender, EventArgs e)
        {
            RequestPriorityHeap priorityHeap = new RequestPriorityHeap();

            var prioritisedRequests = priorityHeap.GetPriorityOrder(
                IssueManager.ReportedIssues);

            dgvRequests.DataSource = null;

            dgvRequests.DataSource = prioritisedRequests
                .Select(issue => new
                {
                    issue.RequestId,
                    issue.Location,
                    issue.Category,
                    issue.DateReported,
                    issue.Status
                })
                .ToList();

            dgvRequests.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            lblRequestCount.Text =
                "Requests prioritised: " + prioritisedRequests.Count;
        }


        private void btnGraphDemo_Click(object sender, EventArgs e)
        {
            ServiceAreaGraph graph = new ServiceAreaGraph();

            // Create example municipal service areas and connections.
            graph.AddConnection("Town Centre", "Residential Area", 4);
            graph.AddConnection("Town Centre", "Industrial Area", 3);
            graph.AddConnection("Residential Area", "Hospital Area", 5);
            graph.AddConnection("Industrial Area", "Hospital Area", 2);
            graph.AddConnection("Residential Area", "Industrial Area", 1);

            // Demonstrate breadth-first and depth-first traversal.
            var bfs = graph.BreadthFirstSearch("Town Centre");
            var dfs = graph.DepthFirstSearch("Town Centre");

            // Calculate the minimum spanning tree.
            var mst = graph.MinimumSpanningTree();

            int totalDistance = 0;
            string mstDetails = "";

            foreach (ServiceAreaConnection connection in mst)
            {
                mstDetails += connection.From + " - " +
                              connection.To + " (Distance: " +
                              connection.Distance + ")" +
                              Environment.NewLine;

                totalDistance += connection.Distance;
            }

            string result =
                "MUNICIPAL SERVICE AREA GRAPH" +
                Environment.NewLine + Environment.NewLine +

                "Breadth-First Search (BFS):" +
                Environment.NewLine +
                string.Join(" -> ", bfs) +
                Environment.NewLine + Environment.NewLine +

                "Depth-First Search (DFS):" +
                Environment.NewLine +
                string.Join(" -> ", dfs) +
                Environment.NewLine + Environment.NewLine +

                "Minimum Spanning Tree (Kruskal's Algorithm):" +
                Environment.NewLine +
                mstDetails +
                "Total distance: " + totalDistance;

            MessageBox.Show(
                result,
                "Graph Algorithm Demonstration",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }


        private void btnSearchAvl_Click(object sender, EventArgs e)
        {
            string searchId = txtRequestId.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchId))
            {
                MessageBox.Show("Please enter a request ID.");
                return;
            }

            RequestAvlTree avlTree = new RequestAvlTree();

            foreach (Issue issue in IssueManager.ReportedIssues)
            {
                avlTree.Insert(issue);
            }

            Issue result = avlTree.Search(searchId);

            if (result == null)
            {
                MessageBox.Show("Request not found in the AVL tree.");
                return;
            }

            dgvRequests.DataSource = null;
            dgvRequests.DataSource = new[]
            {
        new
        {
            result.RequestId,
            result.Location,
            result.Category,
            result.DateReported,
            result.Status
        }
    };

            dgvRequests.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            lblRequestCount.Text = "AVL tree height: " + avlTree.TreeHeight;

            MessageBox.Show(
                "Request found using the AVL tree.\n" +
                "Tree height: " + avlTree.TreeHeight,
                "AVL Tree Search",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }


        private void btnSearchRedBlack_Click(object sender, EventArgs e)
        {
            string searchId = txtRequestId.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchId))
            {
                MessageBox.Show("Please enter a request ID.");
                return;
            }

            RequestRedBlackTree redBlackTree =
                new RequestRedBlackTree();

            foreach (Issue issue in IssueManager.ReportedIssues)
            {
                redBlackTree.Insert(issue);
            }

            Issue result = redBlackTree.Search(searchId);

            if (result == null)
            {
                MessageBox.Show("Request not found in the red-black tree.");
                return;
            }

            dgvRequests.DataSource = null;
            dgvRequests.DataSource = new[]
            {
        new
        {
            result.RequestId,
            result.Location,
            result.Category,
            result.DateReported,
            result.Status
        }
    };

            dgvRequests.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            lblRequestCount.Text =
                "Red-black tree requests: " + redBlackTree.Count;

            MessageBox.Show(
                "Request found using the red-black tree.\n" +
                "Requests indexed: " + redBlackTree.Count,
                "Red-Black Tree Search",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }
}
