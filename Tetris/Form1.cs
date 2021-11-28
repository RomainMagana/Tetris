using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Tetris.Handler;

namespace Tetris
{
    public partial class Form1 : Form
    {
        /***********************************************************|Constructor|********************************************************/
        public Form1()
        {
            InitializeComponent();

            loadCanvas();

            currentShape = getRandomShapeAtCenter();

            timer.Tick += Timer_Tick;
            timer.Interval = 20;
            timer.Start();
        }

        /***********************************************************|Properties|*********************************************************/

        Bitmap canvasBitmap;
        Graphics canvasGraphics;

        int canvasWidth = 20;
        int canvasHeight = 30;
        int[,] canvasDotArray;
        int pointSize = 20;
        int currentX;
        int currentY;

        Shape currentShape;
        Timer timer = new Timer();

        /************************************************************|Methode|***********************************************************/

        // Canvas
        private void loadCanvas()
        {
            // Resize le picture box
            pictureBox1.Width = canvasWidth * pointSize;
            pictureBox1.Height = canvasHeight * pointSize;

            // Creer Bitmap avec la taille de picture box
            canvasBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            canvasGraphics = Graphics.FromImage(canvasBitmap);

            canvasGraphics.FillRectangle(Brushes.LightGray, 0, 0, canvasBitmap.Width, canvasBitmap.Height);

            // Charger le bitmap dans picture box
            pictureBox1.Image = canvasBitmap;

            // Init tab
            canvasDotArray = new int[canvasWidth, canvasHeight];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Positions
        private Shape getRandomShapeAtCenter()
        {
            var shape = Handler.getRandomShape();

            // Ajuster la variable currentX pour que la forme soit dessinée en position centrale
            currentX = 7;
            currentY = -shape.height;

            return shape;
        }

        // Return si curentForme touche une forme ou le sol
        private bool moveShapeIfPossible(int moveDown = 0, int moveSide = 0)
        {
            var newX = currentX + moveSide;
            var newY = currentY + moveDown;

            // check if it reaches the bottom or side bar
            if (newX < 0 || newX + currentShape.width > canvasWidth
                || newY + currentShape.height > canvasHeight)
                return false;

            // check if it touches any other blocks 
            for (int i = 0; i < currentShape.width; i++) {
                for (int j = 0; j < currentShape.height; j++) {
                    if (newY + j > 0 && canvasDotArray[newX + i, newY + j] == 1 && currentShape.points[j, i] == 1)
                        return false;
                }
            }

            currentX = newX;
            currentY = newY;

            drawShape();

            return true;
        }


        // Shape
        Bitmap workBitmap;
        Graphics workGraphics;

        private void drawShape()
        {
            workBitmap = new Bitmap(canvasBitmap);
            workGraphics = Graphics.FromImage(workBitmap);

            for (int i = 0; i < currentShape.width; i++) {
                for (int j = 0; j < currentShape.height; j++) {
                    if (currentShape.points[j, i] == 1)
                        // Changer la couleur / TailleX / TailleY de la forme
                        workGraphics.FillRectangle(Brushes.Red, (currentX + i) * pointSize, (currentY + j) * pointSize, pointSize, pointSize);
                }
            }

            pictureBox1.Image = workBitmap;
        }

        private void updateCanvasDotArrayWithCurrentShape()
        {
            for (int i = 0; i < currentShape.width; i++) {
                for (int j = 0; j < currentShape.height; j++) {
                    if (currentShape.points[j, i] == 1) {
                        checkIfGameOver();
                        canvasDotArray[currentX + i, currentY + j] = 1;
                    }
                }
            }
        }

        //Conditions de sortie
        private void checkIfGameOver()
        {
            if (currentY < 0) {
                timer.Stop();
                MessageBox.Show("Game Over");
                Application.Exit();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var isMoveSuccess = moveShapeIfPossible(moveDown: 1);

            // if shape reached bottom or touched any other shapes
            if (!isMoveSuccess) {
                // copy working image into canvas image
                canvasBitmap = new Bitmap(workBitmap);

                updateCanvasDotArrayWithCurrentShape();

                // get next shape
                currentShape = getRandomShapeAtCenter();
            }
        }

    }
}