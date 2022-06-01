using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Viewer
{
	public partial class Form1 : Form
	{
		//автоматически созданный конструктор формы.
		/// <summary>
		/// конструктор формы (окна).
		/// </summary>
		public Form1()
		{
			InitializeComponent();
		}

		//события (кнопки)
		/// <summary>
		/// нажатие на кнопку "показать".
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void показывалка_клик(object sender, EventArgs e)
		{
			//открывает диалоговое окно с выбором картинки.
			//если пользователь нажимает OK, то картинка загружается в форму (окно).
			if (openFileDialog1.ShowDialog() == DialogResult.OK) картинная.Load(openFileDialog1.FileName);
		}
		
		/// <summary>
		/// нажатие на кнопку "очистить".
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void очищалка_клик(object sender, EventArgs e)
		{
			//очистка окна от картинок.
			картинная.Image = null;
		}

		/// <summary>
		/// нажатие на кнопку "цвет фона".
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void цветоменялка_клик(object sender, EventArgs e)
		{
			//открывает диалоговое окно с выбором цвета.
			//если пользователь нажимает OK, то устанавливается цвет в форму (окно).
			if (colorDialog1.ShowDialog() == DialogResult.OK) картинная.BackColor = colorDialog1.Color;
		}

		/// <summary>
		/// нажатие на кнопку "закрыть".
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void закрывалка_клик(object sender, EventArgs e)
		{
			//закрывает форму.
			Close();
		}

		/// <summary>
		/// нажатие на галочку (checkbox) "растянуть".
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void растягивалка_изменение(object sender, EventArgs e)
		{
			//если нажата галочка, то картинка растягивается.
			//иначе картинка снова становится нормальной.
			if (растягивалка.Checked) картинная.SizeMode = PictureBoxSizeMode.StretchImage;
			else картинная.SizeMode = PictureBoxSizeMode.Normal;
		}
	}
}