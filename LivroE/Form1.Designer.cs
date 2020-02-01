namespace LivroE
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRegistro = new System.Windows.Forms.TabPage();
            this.tabEmancipado = new System.Windows.Forms.TabPage();
            this.tabInterditado = new System.Windows.Forms.TabPage();
            this.tabCurador = new System.Windows.Forms.TabPage();
            this.tabRegistroExterior = new System.Windows.Forms.TabPage();
            this.tabOptante = new System.Windows.Forms.TabPage();
            this.tabAdotado = new System.Windows.Forms.TabPage();
            this.tabTutor = new System.Windows.Forms.TabPage();
            this.tabEscritura = new System.Windows.Forms.TabPage();
            this.tabSentença = new System.Windows.Forms.TabPage();
            this.tabTranscricaoSentenca = new System.Windows.Forms.TabPage();
            this.tabCasamentoTranslado = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.groupRegistro = new System.Windows.Forms.GroupBox();
            this.btnNovoSubAto = new System.Windows.Forms.Button();
            this.btnEditarSubAto = new System.Windows.Forms.Button();
            this.cmbSubAto = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtMensagemAlerta = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtUsuarioInclusao = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDataInclusao = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDataAverbacao = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbStatusRegistro = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNumeroAutos = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSelecionarProcesso = new System.Windows.Forms.Button();
            this.txtNumeroProtocolo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumeroGuiaRecolhimento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDataRegistro = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumeroRegistro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumeroPagina2 = new System.Windows.Forms.TextBox();
            this.txtNumeroPagina = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumeroLivro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAcervo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNumerarAutomaticamente = new System.Windows.Forms.Button();
            this.txtRegistrarLivro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNaturezaAto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupVariaveis = new System.Windows.Forms.GroupBox();
            this.pnlVarAdicionais = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabRegistro.SuspendLayout();
            this.groupRegistro.SuspendLayout();
            this.groupVariaveis.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabRegistro);
            this.tabControl1.Controls.Add(this.tabEmancipado);
            this.tabControl1.Controls.Add(this.tabInterditado);
            this.tabControl1.Controls.Add(this.tabCurador);
            this.tabControl1.Controls.Add(this.tabRegistroExterior);
            this.tabControl1.Controls.Add(this.tabOptante);
            this.tabControl1.Controls.Add(this.tabAdotado);
            this.tabControl1.Controls.Add(this.tabTutor);
            this.tabControl1.Controls.Add(this.tabEscritura);
            this.tabControl1.Controls.Add(this.tabSentença);
            this.tabControl1.Controls.Add(this.tabTranscricaoSentenca);
            this.tabControl1.Controls.Add(this.tabCasamentoTranslado);
            this.tabControl1.Controls.Add(this.tabPage11);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1072, 652);
            this.tabControl1.TabIndex = 0;
            // 
            // tabRegistro
            // 
            this.tabRegistro.Controls.Add(this.groupVariaveis);
            this.tabRegistro.Controls.Add(this.groupRegistro);
            this.tabRegistro.Location = new System.Drawing.Point(4, 22);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistro.Size = new System.Drawing.Size(1064, 626);
            this.tabRegistro.TabIndex = 0;
            this.tabRegistro.Text = "Registro";
            this.tabRegistro.UseVisualStyleBackColor = true;
            // 
            // tabEmancipado
            // 
            this.tabEmancipado.Location = new System.Drawing.Point(4, 22);
            this.tabEmancipado.Name = "tabEmancipado";
            this.tabEmancipado.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmancipado.Size = new System.Drawing.Size(1064, 626);
            this.tabEmancipado.TabIndex = 1;
            this.tabEmancipado.Text = "Emancipado";
            this.tabEmancipado.UseVisualStyleBackColor = true;
            // 
            // tabInterditado
            // 
            this.tabInterditado.Location = new System.Drawing.Point(4, 22);
            this.tabInterditado.Name = "tabInterditado";
            this.tabInterditado.Padding = new System.Windows.Forms.Padding(3);
            this.tabInterditado.Size = new System.Drawing.Size(788, 365);
            this.tabInterditado.TabIndex = 2;
            this.tabInterditado.Text = "Interditado";
            this.tabInterditado.UseVisualStyleBackColor = true;
            // 
            // tabCurador
            // 
            this.tabCurador.Location = new System.Drawing.Point(4, 22);
            this.tabCurador.Name = "tabCurador";
            this.tabCurador.Padding = new System.Windows.Forms.Padding(3);
            this.tabCurador.Size = new System.Drawing.Size(788, 365);
            this.tabCurador.TabIndex = 3;
            this.tabCurador.Text = "Curador";
            this.tabCurador.UseVisualStyleBackColor = true;
            // 
            // tabRegistroExterior
            // 
            this.tabRegistroExterior.Location = new System.Drawing.Point(4, 22);
            this.tabRegistroExterior.Name = "tabRegistroExterior";
            this.tabRegistroExterior.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistroExterior.Size = new System.Drawing.Size(788, 365);
            this.tabRegistroExterior.TabIndex = 4;
            this.tabRegistroExterior.Text = "Registro no Exterior";
            this.tabRegistroExterior.UseVisualStyleBackColor = true;
            // 
            // tabOptante
            // 
            this.tabOptante.Location = new System.Drawing.Point(4, 22);
            this.tabOptante.Name = "tabOptante";
            this.tabOptante.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptante.Size = new System.Drawing.Size(788, 365);
            this.tabOptante.TabIndex = 5;
            this.tabOptante.Text = "Optante";
            this.tabOptante.UseVisualStyleBackColor = true;
            // 
            // tabAdotado
            // 
            this.tabAdotado.Location = new System.Drawing.Point(4, 22);
            this.tabAdotado.Name = "tabAdotado";
            this.tabAdotado.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdotado.Size = new System.Drawing.Size(788, 365);
            this.tabAdotado.TabIndex = 6;
            this.tabAdotado.Text = "Adotado";
            this.tabAdotado.UseVisualStyleBackColor = true;
            // 
            // tabTutor
            // 
            this.tabTutor.Location = new System.Drawing.Point(4, 22);
            this.tabTutor.Name = "tabTutor";
            this.tabTutor.Padding = new System.Windows.Forms.Padding(3);
            this.tabTutor.Size = new System.Drawing.Size(788, 365);
            this.tabTutor.TabIndex = 7;
            this.tabTutor.Text = "Tutor";
            this.tabTutor.UseVisualStyleBackColor = true;
            // 
            // tabEscritura
            // 
            this.tabEscritura.Location = new System.Drawing.Point(4, 22);
            this.tabEscritura.Name = "tabEscritura";
            this.tabEscritura.Padding = new System.Windows.Forms.Padding(3);
            this.tabEscritura.Size = new System.Drawing.Size(788, 365);
            this.tabEscritura.TabIndex = 8;
            this.tabEscritura.Text = "Escritura";
            this.tabEscritura.UseVisualStyleBackColor = true;
            // 
            // tabSentença
            // 
            this.tabSentença.Location = new System.Drawing.Point(4, 22);
            this.tabSentença.Name = "tabSentença";
            this.tabSentença.Padding = new System.Windows.Forms.Padding(3);
            this.tabSentença.Size = new System.Drawing.Size(788, 365);
            this.tabSentença.TabIndex = 9;
            this.tabSentença.Text = "Sentença";
            this.tabSentença.UseVisualStyleBackColor = true;
            // 
            // tabTranscricaoSentenca
            // 
            this.tabTranscricaoSentenca.Location = new System.Drawing.Point(4, 22);
            this.tabTranscricaoSentenca.Name = "tabTranscricaoSentenca";
            this.tabTranscricaoSentenca.Padding = new System.Windows.Forms.Padding(3);
            this.tabTranscricaoSentenca.Size = new System.Drawing.Size(788, 365);
            this.tabTranscricaoSentenca.TabIndex = 10;
            this.tabTranscricaoSentenca.Text = "Transcrição da Sentença";
            this.tabTranscricaoSentenca.UseVisualStyleBackColor = true;
            // 
            // tabCasamentoTranslado
            // 
            this.tabCasamentoTranslado.Location = new System.Drawing.Point(4, 22);
            this.tabCasamentoTranslado.Name = "tabCasamentoTranslado";
            this.tabCasamentoTranslado.Padding = new System.Windows.Forms.Padding(3);
            this.tabCasamentoTranslado.Size = new System.Drawing.Size(788, 365);
            this.tabCasamentoTranslado.TabIndex = 11;
            this.tabCasamentoTranslado.Text = "Casamento Translado";
            this.tabCasamentoTranslado.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(788, 365);
            this.tabPage11.TabIndex = 12;
            this.tabPage11.Text = "tabPage11";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // groupRegistro
            // 
            this.groupRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupRegistro.Controls.Add(this.btnNovoSubAto);
            this.groupRegistro.Controls.Add(this.btnEditarSubAto);
            this.groupRegistro.Controls.Add(this.cmbSubAto);
            this.groupRegistro.Controls.Add(this.label20);
            this.groupRegistro.Controls.Add(this.txtMensagemAlerta);
            this.groupRegistro.Controls.Add(this.label19);
            this.groupRegistro.Controls.Add(this.txtUsuarioInclusao);
            this.groupRegistro.Controls.Add(this.label17);
            this.groupRegistro.Controls.Add(this.txtDataInclusao);
            this.groupRegistro.Controls.Add(this.label18);
            this.groupRegistro.Controls.Add(this.textBox9);
            this.groupRegistro.Controls.Add(this.label16);
            this.groupRegistro.Controls.Add(this.txtDataAverbacao);
            this.groupRegistro.Controls.Add(this.label15);
            this.groupRegistro.Controls.Add(this.cmbTipo);
            this.groupRegistro.Controls.Add(this.label14);
            this.groupRegistro.Controls.Add(this.cmbStatusRegistro);
            this.groupRegistro.Controls.Add(this.label13);
            this.groupRegistro.Controls.Add(this.txtNumeroAutos);
            this.groupRegistro.Controls.Add(this.label12);
            this.groupRegistro.Controls.Add(this.btnSelecionarProcesso);
            this.groupRegistro.Controls.Add(this.txtNumeroProtocolo);
            this.groupRegistro.Controls.Add(this.label11);
            this.groupRegistro.Controls.Add(this.txtNumeroGuiaRecolhimento);
            this.groupRegistro.Controls.Add(this.label10);
            this.groupRegistro.Controls.Add(this.txtDataRegistro);
            this.groupRegistro.Controls.Add(this.label9);
            this.groupRegistro.Controls.Add(this.txtNumeroRegistro);
            this.groupRegistro.Controls.Add(this.label8);
            this.groupRegistro.Controls.Add(this.txtNumeroPagina2);
            this.groupRegistro.Controls.Add(this.txtNumeroPagina);
            this.groupRegistro.Controls.Add(this.label7);
            this.groupRegistro.Controls.Add(this.txtNumeroLivro);
            this.groupRegistro.Controls.Add(this.label6);
            this.groupRegistro.Controls.Add(this.txtNomeLivro);
            this.groupRegistro.Controls.Add(this.label5);
            this.groupRegistro.Controls.Add(this.cmbAcervo);
            this.groupRegistro.Controls.Add(this.label4);
            this.groupRegistro.Controls.Add(this.btnNumerarAutomaticamente);
            this.groupRegistro.Controls.Add(this.txtRegistrarLivro);
            this.groupRegistro.Controls.Add(this.label3);
            this.groupRegistro.Controls.Add(this.cmbAto);
            this.groupRegistro.Controls.Add(this.label2);
            this.groupRegistro.Controls.Add(this.cmbNaturezaAto);
            this.groupRegistro.Controls.Add(this.label1);
            this.groupRegistro.Location = new System.Drawing.Point(6, 6);
            this.groupRegistro.Name = "groupRegistro";
            this.groupRegistro.Size = new System.Drawing.Size(1052, 457);
            this.groupRegistro.TabIndex = 1;
            this.groupRegistro.TabStop = false;
            this.groupRegistro.Text = "Registro";
            // 
            // btnNovoSubAto
            // 
            this.btnNovoSubAto.Location = new System.Drawing.Point(648, 386);
            this.btnNovoSubAto.Name = "btnNovoSubAto";
            this.btnNovoSubAto.Size = new System.Drawing.Size(66, 23);
            this.btnNovoSubAto.TabIndex = 44;
            this.btnNovoSubAto.Text = "Novo";
            this.btnNovoSubAto.UseVisualStyleBackColor = true;
            // 
            // btnEditarSubAto
            // 
            this.btnEditarSubAto.Location = new System.Drawing.Point(576, 386);
            this.btnEditarSubAto.Name = "btnEditarSubAto";
            this.btnEditarSubAto.Size = new System.Drawing.Size(66, 23);
            this.btnEditarSubAto.TabIndex = 43;
            this.btnEditarSubAto.Text = "Editar";
            this.btnEditarSubAto.UseVisualStyleBackColor = true;
            // 
            // cmbSubAto
            // 
            this.cmbSubAto.FormattingEnabled = true;
            this.cmbSubAto.Location = new System.Drawing.Point(208, 388);
            this.cmbSubAto.Name = "cmbSubAto";
            this.cmbSubAto.Size = new System.Drawing.Size(361, 21);
            this.cmbSubAto.TabIndex = 42;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(152, 391);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 13);
            this.label20.TabIndex = 41;
            this.label20.Text = "Sub Atos";
            // 
            // txtMensagemAlerta
            // 
            this.txtMensagemAlerta.Location = new System.Drawing.Point(208, 362);
            this.txtMensagemAlerta.Name = "txtMensagemAlerta";
            this.txtMensagemAlerta.Size = new System.Drawing.Size(549, 20);
            this.txtMensagemAlerta.TabIndex = 40;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(99, 365);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "Mensagem de alerta";
            // 
            // txtUsuarioInclusao
            // 
            this.txtUsuarioInclusao.Location = new System.Drawing.Point(510, 339);
            this.txtUsuarioInclusao.Name = "txtUsuarioInclusao";
            this.txtUsuarioInclusao.Size = new System.Drawing.Size(247, 20);
            this.txtUsuarioInclusao.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(418, 342);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Usuário Inclusão";
            // 
            // txtDataInclusao
            // 
            this.txtDataInclusao.Location = new System.Drawing.Point(208, 336);
            this.txtDataInclusao.Mask = "00/00/0000";
            this.txtDataInclusao.Name = "txtDataInclusao";
            this.txtDataInclusao.Size = new System.Drawing.Size(92, 20);
            this.txtDataInclusao.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(129, 339);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Data Inclusão";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(510, 313);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(247, 20);
            this.textBox9.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(412, 316);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Origem dos dados";
            // 
            // txtDataAverbacao
            // 
            this.txtDataAverbacao.Location = new System.Drawing.Point(208, 310);
            this.txtDataAverbacao.Mask = "00/00/0000";
            this.txtDataAverbacao.Name = "txtDataAverbacao";
            this.txtDataAverbacao.Size = new System.Drawing.Size(92, 20);
            this.txtDataAverbacao.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(118, 313);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Data averbação";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(510, 283);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(247, 21);
            this.cmbTipo.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(476, 286);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Tipo";
            // 
            // cmbStatusRegistro
            // 
            this.cmbStatusRegistro.FormattingEnabled = true;
            this.cmbStatusRegistro.Location = new System.Drawing.Point(208, 283);
            this.cmbStatusRegistro.Name = "cmbStatusRegistro";
            this.cmbStatusRegistro.Size = new System.Drawing.Size(247, 21);
            this.cmbStatusRegistro.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(113, 286);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Status do registro";
            // 
            // txtNumeroAutos
            // 
            this.txtNumeroAutos.Location = new System.Drawing.Point(208, 257);
            this.txtNumeroAutos.Name = "txtNumeroAutos";
            this.txtNumeroAutos.Size = new System.Drawing.Size(549, 20);
            this.txtNumeroAutos.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(109, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Número dos autos";
            // 
            // btnSelecionarProcesso
            // 
            this.btnSelecionarProcesso.Location = new System.Drawing.Point(614, 228);
            this.btnSelecionarProcesso.Name = "btnSelecionarProcesso";
            this.btnSelecionarProcesso.Size = new System.Drawing.Size(143, 23);
            this.btnSelecionarProcesso.TabIndex = 24;
            this.btnSelecionarProcesso.Text = "Selecionar Processo";
            this.btnSelecionarProcesso.UseVisualStyleBackColor = true;
            // 
            // txtNumeroProtocolo
            // 
            this.txtNumeroProtocolo.Location = new System.Drawing.Point(208, 231);
            this.txtNumeroProtocolo.Name = "txtNumeroProtocolo";
            this.txtNumeroProtocolo.Size = new System.Drawing.Size(400, 20);
            this.txtNumeroProtocolo.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(95, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Número do Protocolo";
            // 
            // txtNumeroGuiaRecolhimento
            // 
            this.txtNumeroGuiaRecolhimento.Location = new System.Drawing.Point(208, 205);
            this.txtNumeroGuiaRecolhimento.Name = "txtNumeroGuiaRecolhimento";
            this.txtNumeroGuiaRecolhimento.Size = new System.Drawing.Size(150, 20);
            this.txtNumeroGuiaRecolhimento.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Nº da guia de Recolhimento";
            // 
            // txtDataRegistro
            // 
            this.txtDataRegistro.Location = new System.Drawing.Point(208, 179);
            this.txtDataRegistro.Mask = "00/00/0000";
            this.txtDataRegistro.Name = "txtDataRegistro";
            this.txtDataRegistro.Size = new System.Drawing.Size(150, 20);
            this.txtDataRegistro.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Data do Registro";
            // 
            // txtNumeroRegistro
            // 
            this.txtNumeroRegistro.Location = new System.Drawing.Point(614, 153);
            this.txtNumeroRegistro.Name = "txtNumeroRegistro";
            this.txtNumeroRegistro.Size = new System.Drawing.Size(143, 20);
            this.txtNumeroRegistro.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(512, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Número do registro";
            // 
            // txtNumeroPagina2
            // 
            this.txtNumeroPagina2.Location = new System.Drawing.Point(332, 153);
            this.txtNumeroPagina2.Name = "txtNumeroPagina2";
            this.txtNumeroPagina2.Size = new System.Drawing.Size(26, 20);
            this.txtNumeroPagina2.TabIndex = 15;
            // 
            // txtNumeroPagina
            // 
            this.txtNumeroPagina.Location = new System.Drawing.Point(208, 153);
            this.txtNumeroPagina.Name = "txtNumeroPagina";
            this.txtNumeroPagina.Size = new System.Drawing.Size(121, 20);
            this.txtNumeroPagina.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Número da página";
            // 
            // txtNumeroLivro
            // 
            this.txtNumeroLivro.Location = new System.Drawing.Point(614, 130);
            this.txtNumeroLivro.Name = "txtNumeroLivro";
            this.txtNumeroLivro.Size = new System.Drawing.Size(143, 20);
            this.txtNumeroLivro.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Número do livro";
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Location = new System.Drawing.Point(208, 127);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(121, 20);
            this.txtNomeLivro.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome Do Livro";
            // 
            // cmbAcervo
            // 
            this.cmbAcervo.FormattingEnabled = true;
            this.cmbAcervo.Location = new System.Drawing.Point(208, 100);
            this.cmbAcervo.Name = "cmbAcervo";
            this.cmbAcervo.Size = new System.Drawing.Size(549, 21);
            this.cmbAcervo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Acervo";
            // 
            // btnNumerarAutomaticamente
            // 
            this.btnNumerarAutomaticamente.Location = new System.Drawing.Point(461, 73);
            this.btnNumerarAutomaticamente.Name = "btnNumerarAutomaticamente";
            this.btnNumerarAutomaticamente.Size = new System.Drawing.Size(157, 23);
            this.btnNumerarAutomaticamente.TabIndex = 6;
            this.btnNumerarAutomaticamente.Text = "Numerar Automaticamente";
            this.btnNumerarAutomaticamente.UseVisualStyleBackColor = true;
            // 
            // txtRegistrarLivro
            // 
            this.txtRegistrarLivro.FormattingEnabled = true;
            this.txtRegistrarLivro.Location = new System.Drawing.Point(208, 73);
            this.txtRegistrarLivro.Name = "txtRegistrarLivro";
            this.txtRegistrarLivro.Size = new System.Drawing.Size(247, 21);
            this.txtRegistrarLivro.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Registrar no Livro";
            // 
            // cmbAto
            // 
            this.cmbAto.FormattingEnabled = true;
            this.cmbAto.Location = new System.Drawing.Point(208, 46);
            this.cmbAto.Name = "cmbAto";
            this.cmbAto.Size = new System.Drawing.Size(549, 21);
            this.cmbAto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ato";
            // 
            // cmbNaturezaAto
            // 
            this.cmbNaturezaAto.FormattingEnabled = true;
            this.cmbNaturezaAto.Location = new System.Drawing.Point(208, 19);
            this.cmbNaturezaAto.Name = "cmbNaturezaAto";
            this.cmbNaturezaAto.Size = new System.Drawing.Size(549, 21);
            this.cmbNaturezaAto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Natureza do Ato";
            // 
            // groupVariaveis
            // 
            this.groupVariaveis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupVariaveis.Controls.Add(this.pnlVarAdicionais);
            this.groupVariaveis.Location = new System.Drawing.Point(6, 469);
            this.groupVariaveis.Name = "groupVariaveis";
            this.groupVariaveis.Size = new System.Drawing.Size(1052, 151);
            this.groupVariaveis.TabIndex = 2;
            this.groupVariaveis.TabStop = false;
            this.groupVariaveis.Text = "Váriaveis Adicionais";
            // 
            // pnlVarAdicionais
            // 
            this.pnlVarAdicionais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVarAdicionais.Location = new System.Drawing.Point(8, 19);
            this.pnlVarAdicionais.Name = "pnlVarAdicionais";
            this.pnlVarAdicionais.Size = new System.Drawing.Size(1038, 126);
            this.pnlVarAdicionais.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1096, 676);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livro E";
            this.tabControl1.ResumeLayout(false);
            this.tabRegistro.ResumeLayout(false);
            this.groupRegistro.ResumeLayout(false);
            this.groupRegistro.PerformLayout();
            this.groupVariaveis.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRegistro;
        private System.Windows.Forms.TabPage tabEmancipado;
        private System.Windows.Forms.TabPage tabInterditado;
        private System.Windows.Forms.TabPage tabCurador;
        private System.Windows.Forms.TabPage tabRegistroExterior;
        private System.Windows.Forms.TabPage tabOptante;
        private System.Windows.Forms.TabPage tabAdotado;
        private System.Windows.Forms.TabPage tabTutor;
        private System.Windows.Forms.TabPage tabEscritura;
        private System.Windows.Forms.TabPage tabSentença;
        private System.Windows.Forms.TabPage tabTranscricaoSentenca;
        private System.Windows.Forms.TabPage tabCasamentoTranslado;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.GroupBox groupVariaveis;
        private System.Windows.Forms.Panel pnlVarAdicionais;
        private System.Windows.Forms.GroupBox groupRegistro;
        private System.Windows.Forms.Button btnNovoSubAto;
        private System.Windows.Forms.Button btnEditarSubAto;
        private System.Windows.Forms.ComboBox cmbSubAto;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtMensagemAlerta;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtUsuarioInclusao;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox txtDataInclusao;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox txtDataAverbacao;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbStatusRegistro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNumeroAutos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSelecionarProcesso;
        private System.Windows.Forms.TextBox txtNumeroProtocolo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumeroGuiaRecolhimento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtDataRegistro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumeroRegistro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumeroPagina2;
        private System.Windows.Forms.TextBox txtNumeroPagina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumeroLivro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAcervo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNumerarAutomaticamente;
        private System.Windows.Forms.ComboBox txtRegistrarLivro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNaturezaAto;
        private System.Windows.Forms.Label label1;
    }
}

