namespace WaveFit.Classes
{
    /// <summary>
    /// Classe usada para a troca de mensagens entre as ViewModels
    /// </summary>
    public static class Communication
    {
        /// <summary>
        /// Inicializa o messenger
        /// </summary>
        static Communication()
        {
            Messaging = new Messenger();
        }

		public static Messenger Messaging { get; set; }

		/// <summary>
		/// Mensagem avisando que o nivel de adaptação mudou
		/// </summary>
		public static string AdaptationLevelChanged
		{
			get { return "AdaptationLevel"; }
		}

		/// <summary>
		/// Mensagem disparada para adicionar paciente ao banco de dados; 
		/// </summary>
		public static string AddPatient
		{
			get { return "AddPatient"; }
		}

		public static string AddValueFinished
		{
			get { return "AddValueFinished"; }
		}

		/// <summary>
		/// Mensagem disparada pela view model do ajuste quando ocorrer mudanças de parâmetros, informando
		/// se existem mudanças que ainda não foram salvas.
		/// </summary>
		public static string AdjustNotSavedChanged
		{
			get { return "AdjustNotSavedChanged"; }
		}

        /// <summary>
        /// Mensagem avisando qual a interface da categoria
        /// </summary>
		public static string CategoryInterface
		{
            get { return "CategoryInterface"; }
		}

		/// <summary>
		/// Mensagem para alterar o texto da tela de detecção de hardware
		/// </summary>
		public static string ChangeProgressWindow
		{
			get { return "ChangeProgressWindow"; }
		}

		/// <summary>
		/// Mensagem para alterar a tela do modo de configuração (administrador)
		/// </summary>
		public static string ChangeAdminScreen
		{
			get { return "ChangeAdminScreen"; }
		}

		public static string ChipSelected
		{
			get { return "ChipSelected"; }
		}

		public static string ChipUpdated
		{
			get { return "ChipUpdated"; }
		}

		/// <summary>
		/// Mensagem disparada para fechar a janela com a barra de progresso indefinida;
		/// </summary>
		public static string CloseProgressWindow
		{
			get { return "CloseProgressWindow"; }
		}

		/// <summary>
		/// Mensagem disparada quando uma linha de um gráfico será copiada para o outro gráfico
		/// </summary>
		public static string CopyLine
		{
			get { return "CopyLine"; }
		}

        public static string DatalogStart
        {
            get { return "DatalogStart"; }
        }

		/// <summary>
		/// Mensagem disparada quando uma linha de um gráfico deve ser deletada 
		/// </summary>
		public static string DeleteLine
		{
			get { return "DeleteLine"; }
		}

		/// <summary>
		/// Mensagem disparada quando a detecção de hardware é solicitada.
		/// </summary>
		public static string DetectHardware
		{
			get { return "DetectHardware"; }
		}

		/// <summary>
		/// Mensagem disparada para desabilitar o botão do audiograma; 
		/// </summary>
		public static string DisableAudiogram
		{
			get { return "DisableAudiogram"; }
		}

		/// <summary>
		/// Mensagem disparada pelo módulo de ajuste para desabilitar o botão desfazer do Fitting Assistance
		/// </summary>
		public static string DisableAdjustUndo
		{
			get { return "DisableAdjustUndo"; }
		}

        /// <summary>
        /// Mensagem disparada para descartar as mudanças no formulário do paciente;
        /// </summary>
        public static string DiscardPatientFormChanges
        {
            get { return "DiscardPatientFormChanges"; }
        }

        /// <summary>
        /// Mensagem disparada para exibir a tela de sobrescrita de Dlls;
        /// </summary>
        public static string DllOverrideShow
        {
            get { return "DllOverrideShow"; }
        }

		/// <summary>
		/// Mensagem de mudança de ouvido selecionado
		/// </summary>
		public static string EarChanged
		{
			get { return "EarChanged"; }
		}

        /// <summary>
        /// Mensagem informando qual categoria deve ser editada
        /// </summary>
        public static string EditChipCategory
        {
            get { return "EditChipCategory"; }
        }

		/// <summary>
		/// Mensagem para finalizar o ajuste
		/// </summary>
		public static string FinishAdjust
		{
			get { return "FinishAdjust"; }
		}

		/// <summary>
		/// Mensagem disparada para dialogo de configuração do formulário; 
		/// </summary>
		public static string FormCloseConfig
		{
			get { return "FormCloseConfig"; }
		}

		/// <summary>
		/// Mensagem disparada para dialogo de configuração do formulário; 
		/// </summary>
		public static string FormConfig
		{
			get { return "FormConfig"; }
		}

		/// <summary>
		/// Mensagem disparada para dialogo de configuração do formulário; 
		/// </summary>
		public static string FormSaveConfig
		{
			get { return "FormSaveConfig"; }
		}

		/// <summary>
		/// Mensagem disparada para dialogo de configuração do formulário; 
		/// </summary>
		public static string FormUpdateConfig
		{
			get { return "FormUpdateConfig"; }
		}

		public static string HearingAidIdUpdated
		{
			get { return "HearingAidIdUpdated"; }
		}

		public static string HearingAidUpdated
		{
			get { return "HearingAidUpdated"; }
		}

        /// <summary>
        /// Mensagem para esconder o datalog
        /// </summary>
        public static string HideDatalog
        {
            get { return "HideDatalog"; }
        }

        /// <summary>
        /// Mensagem para esconder o FittingAssistance
        /// </summary>
        public static string HideFittingAssistance
        {
            get { return "HideFittingAssistance"; }
        }

		/// <summary>
		/// Mensagem disparada quando uma audiometria ou ajuste é selecionado no histórico.
		/// </summary>
		public static string HistoryActionSelected
		{
			get { return "HistoryActionSelected"; }
		}

        /// <summary>
        /// Mensagem que avisa que a seleção de novo paciente é inválida;
        /// </summary>
        public static string InvalidatePatientUpdate
        {
            get { return "InvalidatePatientUpdate"; }
        }

		/// <summary>
		/// Mensagem para notificar se o parâmetro alterado na interface é válido
		/// Utilizado para evitar erros ao tentar setar um parâmetro com um valor
		/// proibido pela DLL. (Caso WDRC).
		/// </summary>
		public static string IsValidParameterValue
		{
			get { return "IsValidParameterValue"; }
		}

        /// <summary>
		/// Mensagem para ativar o view do Audiograma
		/// </summary>
		public static string LeftModelSelected
		{
			get { return "LeftModelSelected"; }
		}

		/// <summary>
		/// Mensagem disparada sempre que algum parâmetro do aparelho esquerdo for alterado.
		/// </summary>
		public static string LeftParametersChanged
		{
			get { return "LeftParametersChanged"; }
		}

        /// <summary>
		/// Mensagem disparada sempre que a regra de ganho do lado esquerdo for alterada.
		/// </summary>
        public static string LeftPrescriptiveGainsChanged
		{
            get { return "LeftPrescriptiveGainsChanged"; }
		}

		/// <summary>
		/// Mensagem disparada quando o tipo de linha do gráfico é modificada
		/// </summary>
		public static string LineMode
		{
			get { return "LineMode"; }
		}

		/// <summary>
		/// Mensagem disparada para fechar a janela com a barra de progresso indefinida.
		/// </summary>
		public static string Login
		{
			get { return "Login"; }
		}

		/// <summary>
		/// Mensagem para ativar o view do Audiograma
		/// </summary>
		public static string Logout
		{
			get { return "Logout"; }
		}

		/// <summary>
		/// Mensagem para ativar o view do Audiograma
		/// </summary>
		public static string LogoutPressed
		{
			get { return "LogoutPressed"; }
		}

        /// <summary>
        /// Mensagem para trocar o estado da main window
        /// </summary>
        public static string MainWindowState
        {
            get { return "MainWindowState"; }
        }

		/// <summary>
		/// Mensagem disparada quando o usuário passa o cursor por cima dos botões VA, VO e UCL, na tela de audiometria
		/// </summary>
		public static string MouseEnterAudiogramButton
		{
			get { return "MouseEnterAudiogramButton"; }
		}

		/// <summary>
		/// Mensagem disparada quando o usuário tira o cursor de cima dos botões VA, VO e UCL, na tela de audiometria
		/// </summary>
		public static string MouseLeaveAudiogramButton
		{
			get { return "MouseLeaveAudiogramButton"; }
		}

		public static string ParameterAdded
		{
			get { return "ParameterAdded"; }
		}

		/// <summary>
		/// Mensagem disparada quando os controles do ajuste terminarem de carregar os valores dos parâmetros.
		/// </summary>
		public static string ParametersLoaded
		{
			get { return "ParametersLoaded"; }
		}

		/// <summary>
		/// Mensagem disparada pela view model do editor de parâmetros quando ocorrer mudanças, informando
		/// se existem mudanças que ainda não foram salvas.
		/// </summary>
		public static string ParameterNotSavedChanged
		{
			get { return "ParameterNotSavedChanged"; }
		}

		public static string ParameterSelected
		{
			get { return "ParameterSelected"; }
		}

		public static string ParameterStep
		{
			get { return "ParameterStep"; }
		}

        /// <summary>
        /// Mensagem disparada para avisar que o botão editar paciente foi pressionado.
        /// </summary>
        public static string PatientFormEditPatient
        {
            get { return "PatientFormNewPatientState"; }
        }

        /// <summary>
        /// Mensagem disparada para avisar que o botão Remover paciente foi pressionado.
        /// </summary>
        public static string PatientFormErasePatient
        {
            get { return "PatientFormErasePatient"; }
        }

        /// <summary>
        /// Mensagem disparada para avisar que o botão adicionar paciente foi pressionado.
        /// </summary>
        public static string PatientFormNewPatient
        {
            get { return "PatientFormNewPatient"; }
        }
        

        /// <summary>
        /// Mensagem disparada para avisar que existem mudanças não salvas no formulário do paciente.
        /// </summary>
        public static string PatientFormNotSavedChanges
        {
            get { return "PatientFormNotSavedChanges"; }
        }

        /// <summary>
        /// Mensagem disparada para avisar que o estado do formulário do paciente mudou.
        /// </summary>
        public static string PatientFormStateChanged
        {
            get { return "PatientFormStateChanged"; }
        }

		/// <summary>
		/// Mensagem disparada para habilitar o botão do audiograma e informar o formulário qual o paciente em questão; 
		/// </summary>
		public static string PatientSelected
		{
			get { return "PatientSelected"; }
		}

		/// <summary>
		/// Mensagem para ativar o view do Audiograma
		/// </summary>
		public static string PatientUpdated
		{
			get { return "PatientUpdated"; }
		}

		public static string PlotModeChanged
		{
			get { return "PlotModeChanged"; }
		}

		/// <summary>
		/// Mensagem disparada para fechar a janela com a barra de progresso indefinida;
		/// </summary>
		public static string PreviewAdjust
		{
			get { return "PreviewAdjust"; }
		}

		/// <summary>
		/// Mensagem disparada para fechar a janela com a barra de progresso indefinida;
		/// </summary>
		public static string PreviewAdjustVisibility
		{
			get { return "PreviewAdjustVisibility"; }
		}

		/// <summary>
		/// Mensagem disparada para fechar a janela com a barra de progresso indefinida;
		/// </summary>
		public static string PreviewAudiogram
		{
			get { return "PreviewAudiogram"; }
		}

		/// <summary>
		/// Mensagem disparada para fechar a janela com a barra de progresso indefinida;
		/// </summary>
		public static string PreviewAudiogramVisibility
		{
			get { return "PreviewAudiogramVisibility"; }
		}

		/// <summary>
		/// Mensagem disparada pelo Fitting Assistance para desfazer o último ajuste aplicado;
		/// </summary>
		public static string PreviousAdjustConfig
		{
			get { return "PreviousAdjustConfig"; }
		}

		/// <summary>
		/// Mensagem de mudança de produto selecionado
		/// </summary>
		public static string ProductChanged
		{
			get { return "ProductChanged"; }
		}

        /// <summary>
		/// Mensagem disparada quando o botão cancelar da progress window é pressionado
		/// </summary>
        public static string ProgressWindowCancelPressed
		{
            get { return "ProgressWindowCancelPressed"; }
		}
        

		public static string ReceptorUpdated
		{
			get { return "ReceptorUpdated"; }
		}

		public static string RecMicPointUpdated
		{
			get { return "RecMicPointUpdated"; }
		}

        /// <summary>
		/// Mensagem disparada para informar o formulário qual o paciente em questão no modo admin -> addUser; 
		/// </summary>
        public static string RecoverPatientSelected
		{
            get { return "RecoverPatientSelected"; }
		}

		/// <summary>
		/// Mensagem para atualizar o WDRC comboBox.
		/// </summary>
		public static string RefreshWdrcComboBox
		{
			get { return "RefreshWdrcComboBox"; }
		}

		/// <summary>
		/// Mensagem para atualizar o WDRC slider.
		/// </summary>
		public static string RefreshWdrcSlider
		{
			get { return "RefreshWdrcSlider"; }
		}

		public static string RemoveHearinAid
		{
			get { return "RemoveHearingAid"; }
		}

		/// <summary>
		/// Mensagem para ativar o view do Audiograma
		/// </summary>
		public static string RemoveHidePatient
		{
			get { return "RemoveHidePatient"; }
		}

		public static string RemoveParameter
		{
			get { return "RemoveParameter"; }
		}

		/// <summary>
		/// Mensagem disparada para remover paciente ao banco de dados; 
		/// </summary>
		public static string RemovePatient
		{
			get { return "RemovePatient"; }
		}

		/// <summary>
		/// Mensagem disparada sempre que os parâmetros do aparelho forem lidos do chip ou reiniciados para os valores padrão.
		/// </summary>
		public static string ResetParameters
		{
			get { return "ResetParameters"; }
		}

        /// <summary>
        /// Mensagem para ativar o view do Audiograma
        /// </summary>
        public static string RightModelSelected
        {
            get { return "RightModelSelected"; }
        }

		/// <summary>
		/// Mensagem disparada sempre que algum parâmetro do aparelho direito for alterado
		/// </summary>
		public static string RightParametersChanged
		{
			get { return "RightParametersChanged"; }
		}

        /// <summary>
        /// Mensagem disparada sempre que a regra de ganho do lado esquerdo for alterada.
        /// </summary>
        public static string RightPrescriptiveGainsChanged
        {
            get { return "RightPrescriptiveGainsChanged"; }
        }

        /// <summary>
        /// Mensagem disparada para mostrar a interface de renomear memórias do aparelho auditivo.
        /// </summary>
        public static string RenameMemories
        {
            get { return "RenameMemories"; }
        }
        
		/// <summary>
		/// Mensagem disparada para dialogo de configuração do formulário; 
		/// </summary>
		public static string SearchResult
		{
			get { return "SearchResult"; }
		}

		/// <summary>
		/// Mensagem disparada para fechar a janela com a barra de progresso indefinida;
		/// </summary>
		public static string SessionID
		{
			get { return "SessionID"; }
		}

        /// <summary>
        /// Mensagem para mostrar a tela de progresso com botão cancelar.
        /// </summary>
        public static string ShowCancelableProgressWindow
        {
            get { return "ShowCancelableProgressWindow"; }
        }

        /// <summary>
        /// Mensagem para expandir/contrair as views de formulário do paciente.
        /// </summary>
        public static string ShowHelpWindow
        {
            get { return "ShowHelpWindow"; }
        }

        /// <summary>
        /// Mensagem para expandir/contrair as views de formulário do paciente.
        /// </summary>
        public static string ShowHideForm
        {
            get { return "ShowHideForm"; }
        }

        /// <summary>
        /// Mensagem para expandir/contrair as views de formulário do paciente.
        /// </summary>
        public static string ShowHideHistory
        {
            get { return "ShowHideHistory"; }
        }

		/// <summary>
		/// Mensagem para mostrar a tela de progresso.
		/// </summary>
		public static string ShowProgressWindow
		{
			get { return "ShowProgressWindow"; }
		}

		/// <summary>
		/// Mensagem para ativar o view de ajuste das curvas
		/// </summary>
		public static string StartAdjust
		{
			get { return "StartAdjust"; }
		}

		/// <summary>
		/// Mensagem disparada quando a janela principal seleciona o botão hardware
		/// </summary>
		public static string StartAdminModule
		{
			get { return "StartAdminModule"; }
		}

		/// <summary>
		/// Mensagem para ativar o view do Audiograma
		/// </summary>
		public static string StartAudiometry
		{
			get { return "StartAudiometry"; }
		}

		/// <summary>
		/// Começa um audiometria a partir de uma audiometria anterior.
		/// </summary>
		public static string StartFromAudiometry
		{
			get { return "StartFromAudiometry"; }
		}

		/// <summary>
		/// Mensagem para ativar o view do Audiograma
		/// </summary>
		public static string StartHearing
		{
			get { return "StartHearing"; }
		}

		/// <summary>
		/// Mensagem disparada quando a janela principal seleciona o botão hardware
		/// </summary>
		public static string StartPatientModule
		{
			get { return "StartPatientModule"; }
		}

		/// <summary>
		/// Mensagem disparada quando uma célula da tabela do audiograma é modificada
		/// </summary>
		public static string TableEdited
		{
			get { return "TableEdited"; }
		}

		public static string TypeUpdated
		{
			get { return "TypeUpdated"; }
		}

		/// <summary>
		/// Mensagem para ativar o view do Audiograma
		/// </summary>
		public static string UpdateByTable
		{
			get { return "UpdateByTable"; }
		}

        /// <summary>
        /// Mensagem para informar que algum a faixa de adaptação deve ser atualizada.
        /// </summary>
        public static string UpdateFittingRange
        {
            get { return "UpdateFittingRange"; }
        }

        /// <summary>
        /// Mensagem para informar que algum ponto foi modificado no cadastro de faixa de adaptação.
        /// </summary>
        public static string UpdateFittingRangePoint
        {
            get { return "UpdateFittingRangePoint"; }
        }

        /// <summary>
        /// Mensagem para informar que os nomes das memórias devem ser atualizados.
        /// </summary>
        public static string UpdateMemoryNames
        {
            get { return "UpdateMemoryNames"; }
        }

        /// <summary>
		/// Mensagem disparada para atualizar paciente no banco de dados; 
		/// </summary>
		public static string UpdatePatient
		{
			get { return "UpdatePatient"; }
		}

        /// <summary>
        /// Mensagem disparada para atualizar a grid da view de pacientes; 
        /// </summary>
        public static string UpdatePatientGrid
        {
            get { return "UpdatePatientGrid"; }
        }

		/// <summary>
		/// Mensagem disparada para fechar a janela com a barra de progresso indefinida;
		/// </summary>
		public static string UpdateTable
		{
			get { return "UpdateTable"; }
		}

		/// <summary>
		/// Mensagem para ativar o view do Audiograma
		/// </summary>
		public static string UpdateTableList
		{
			get { return "UpdateTableList"; }
		}

        public static string UpdateTableView
        {
            get { return "UpdateTableView"; }
        }

        /// <summary>
        /// Mensagem para modificar o usuário ativo
        /// </summary>
        public static string UpdateUser
        {
            get { return "UpdateUser"; }
        }

        /// <summary>
        /// Mensagem para ativar o view do Audiograma
        /// </summary>
        public static string UserSaved
        {
            get { return "UserSaved"; }
        }

        /// <summary>
        /// Mensagem para ativar o view do Audiograma
        /// </summary>
        public static string UserUpdated
        {
            get { return "UserUpdated"; }
        }

        /// <summary>
        /// Mensagem disparada para fechar a janela com a barra de progresso indefinida;
        /// </summary>
        public static string ViewAudiometry
        {
            get { return "ViewAudiometry"; }
        }

		/// <summary>
		/// Mensagem disparada pelo Fitting Assistance para testar um ajuste que foi aplicado.
		/// </summary>
		public static string WriteAdjust
		{
			get { return "WriteAdjust"; }
		}
    }
}
