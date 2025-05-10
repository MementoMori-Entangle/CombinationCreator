using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CombinationCreator
{
    /// <summary>
    /// 組合わせ生成
    /// </summary>
    public partial class CombinationCreator : Form
    {
        /// <summary>
        /// デフォルト組合わせ区切り文字列
        /// </summary>
        const string COMBINATION_SYMBOL = "：";

        /// <summary>
        /// 数値フォーマット #,##0
        /// </summary>
        const string COMMA_NUMBER_FORMAT = "{0:#,0}";

        /// <summary>
        /// 改行 \n
        /// </summary>
        const string NEW_LINE_N = "\n";

        /// <summary>
        /// 改行 \r
        /// </summary>
        const string NEW_LINE_R = "\r";

        /// <summary>
        /// セパレーター
        /// </summary>
        readonly string[] sp = new string[] { NEW_LINE_N };

        /// <summary>
        /// コンストラクタ処理
        /// </summary>
        public CombinationCreator()
        {
            InitializeComponent();

            GroupACheckBox.Checked = true;
            GroupBCheckBox.Checked = true;
            GroupCCheckBox.Checked = true;
            GroupDCheckBox.Checked = true;
            GroupECheckBox.Checked = true;
            GroupFCheckBox.Checked = true;
            GroupGCheckBox.Checked = true;
            NumberingCheckBox.Checked = false;
            CSTextBox.Text = COMBINATION_SYMBOL;
            GroupARowNumLabel.Text = string.Empty;
            GroupBRowNumLabel.Text = string.Empty;
            GroupCRowNumLabel.Text = string.Empty;
            GroupDRowNumLabel.Text = string.Empty;
            GroupERowNumLabel.Text = string.Empty;
            GroupFRowNumLabel.Text = string.Empty;
            GroupGRowNumLabel.Text = string.Empty;
            CNumberLabel.Text = string.Empty;
            ListOverlappingCheckBox.Checked = false;
        }

        /// <summary>
        /// クリアボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            GroupATextBox.Text = string.Empty;
            GroupBTextBox.Text = string.Empty;
            GroupCTextBox.Text = string.Empty;
            GroupDTextBox.Text = string.Empty;
            GroupETextBox.Text = string.Empty;
            GroupFTextBox.Text = string.Empty;
            GroupGTextBox.Text = string.Empty;
            CSTextBox.Text = COMBINATION_SYMBOL;
            CombinationRichTextBox.Text = string.Empty;
            GroupACheckBox.Checked = true;
            GroupBCheckBox.Checked = true;
            GroupCCheckBox.Checked = true;
            GroupDCheckBox.Checked = true;
            GroupECheckBox.Checked = true;
            GroupFCheckBox.Checked = true;
            GroupGCheckBox.Checked = true;
            NumberingCheckBox.Checked = false;
            GroupARowNumLabel.Text = string.Empty;
            GroupBRowNumLabel.Text = string.Empty;
            GroupCRowNumLabel.Text = string.Empty;
            GroupDRowNumLabel.Text = string.Empty;
            GroupERowNumLabel.Text = string.Empty;
            GroupFRowNumLabel.Text = string.Empty;
            GroupGRowNumLabel.Text = string.Empty;
            CNumberLabel.Text = string.Empty;
            ListOverlappingCheckBox.Checked = false;
        }

        /// <summary>
        /// グループクリアボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupClearButton_Click(object sender, EventArgs e)
        {
            GroupATextBox.Text = string.Empty;
            GroupBTextBox.Text = string.Empty;
            GroupCTextBox.Text = string.Empty;
            GroupDTextBox.Text = string.Empty;
            GroupETextBox.Text = string.Empty;
            GroupFTextBox.Text = string.Empty;
            GroupGTextBox.Text = string.Empty;
            GroupACheckBox.Checked = true;
            GroupBCheckBox.Checked = true;
            GroupCCheckBox.Checked = true;
            GroupDCheckBox.Checked = true;
            GroupECheckBox.Checked = true;
            GroupFCheckBox.Checked = true;
            GroupGCheckBox.Checked = true;
            GroupARowNumLabel.Text = string.Empty;
            GroupBRowNumLabel.Text = string.Empty;
            GroupCRowNumLabel.Text = string.Empty;
            GroupDRowNumLabel.Text = string.Empty;
            GroupERowNumLabel.Text = string.Empty;
            GroupFRowNumLabel.Text = string.Empty;
            GroupGRowNumLabel.Text = string.Empty;
        }

        /// <summary>
        /// グループAエリア移動時、組合わせ対象数処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupATextBox_Leave(object sender, EventArgs e)
        {
            if (GroupACheckBox.Checked)
            {
                string[] texts = this.RemoveBlankAndNewLineData(GroupATextBox.Text.Split(this.sp, StringSplitOptions.None));

                if (null != texts && 0 < texts.Length)
                {
                    GroupARowNumLabel.Text = COMBINATION_SYMBOL + string.Format(COMMA_NUMBER_FORMAT, texts.Length);
                }
            }
        }

        /// <summary>
        /// グループBエリア移動時、組合わせ対象数処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupBTextBox_Leave(object sender, EventArgs e)
        {
            if (GroupBCheckBox.Checked)
            {
                string[] texts = this.RemoveBlankAndNewLineData(GroupBTextBox.Text.Split(this.sp, StringSplitOptions.None));

                if (null != texts && 0 < texts.Length)
                {
                    GroupBRowNumLabel.Text = COMBINATION_SYMBOL + string.Format(COMMA_NUMBER_FORMAT, texts.Length);
                }
            }
        }

        /// <summary>
        /// グループCエリア移動時、組合わせ対象数処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupCTextBox_Leave(object sender, EventArgs e)
        {
            if (GroupCCheckBox.Checked)
            {
                string[] texts = this.RemoveBlankAndNewLineData(GroupCTextBox.Text.Split(this.sp, StringSplitOptions.None));

                if (null != texts && 0 < texts.Length)
                {
                    GroupCRowNumLabel.Text = COMBINATION_SYMBOL + string.Format(COMMA_NUMBER_FORMAT, texts.Length);
                }
            }
        }

        /// <summary>
        /// グループDエリア移動時、組合わせ対象数処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupDTextBox_Leave(object sender, EventArgs e)
        {
            if (GroupDCheckBox.Checked)
            {
                string[] texts = this.RemoveBlankAndNewLineData(GroupDTextBox.Text.Split(this.sp, StringSplitOptions.None));

                if (null != texts && 0 < texts.Length)
                {
                    GroupDRowNumLabel.Text = COMBINATION_SYMBOL + string.Format(COMMA_NUMBER_FORMAT, texts.Length);
                }
            }
        }

        /// <summary>
        /// グループEエリア移動時、組合わせ対象数処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupETextBox_Leave(object sender, EventArgs e)
        {
            if (GroupECheckBox.Checked)
            {
                string[] texts = this.RemoveBlankAndNewLineData(GroupETextBox.Text.Split(this.sp, StringSplitOptions.None));

                if (null != texts && 0 < texts.Length)
                {
                    GroupERowNumLabel.Text = COMBINATION_SYMBOL + string.Format(COMMA_NUMBER_FORMAT, texts.Length);
                }
            }
        }

        /// <summary>
        /// グループFエリア移動時、組合わせ対象数処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupFTextBox_Leave(object sender, EventArgs e)
        {
            if (GroupFCheckBox.Checked)
            {
                string[] texts = this.RemoveBlankAndNewLineData(GroupFTextBox.Text.Split(this.sp, StringSplitOptions.None));

                if (null != texts && 0 < texts.Length)
                {
                    GroupFRowNumLabel.Text = COMBINATION_SYMBOL + string.Format(COMMA_NUMBER_FORMAT, texts.Length);
                }
            }
        }

        /// <summary>
        /// グループGエリア移動時、組合わせ対象数処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupGTextBox_Leave(object sender, EventArgs e)
        {
            if (GroupACheckBox.Checked)
            {
                string[] texts = this.RemoveBlankAndNewLineData(GroupGTextBox.Text.Split(this.sp, StringSplitOptions.None));

                if (null != texts && 0 < texts.Length)
                {
                    GroupGRowNumLabel.Text = COMBINATION_SYMBOL + string.Format(COMMA_NUMBER_FORMAT, texts.Length);
                }
            }
        }

        /// <summary>
        /// 組合わせボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CombinationButton_Click(object sender, EventArgs e)
        {
            List<string[]> sourceList = new List<string[]>();

            string[] texts = null;
            
            if (GroupACheckBox.Checked)
            {
                texts = this.RemoveBlankAndNewLineData(GroupATextBox.Text.Split(this.sp, StringSplitOptions.None));

                if (null != texts && 0 < texts.Length)
                {
                    sourceList.Add(texts);
                }
            }

            if (GroupBCheckBox.Checked)
            {
                texts = this.RemoveBlankAndNewLineData(GroupBTextBox.Text.Split(this.sp, StringSplitOptions.None));

                if (null != texts && 0 < texts.Length)
                {
                    sourceList.Add(texts);
                }
            }

            if (GroupCCheckBox.Checked)
            {
                texts = this.RemoveBlankAndNewLineData(GroupCTextBox.Text.Split(this.sp, StringSplitOptions.None));

                if (null != texts && 0 < texts.Length)
                {
                    sourceList.Add(texts);
                }
            }

            if (GroupDCheckBox.Checked)
            {
                texts = this.RemoveBlankAndNewLineData(GroupDTextBox.Text.Split(this.sp, StringSplitOptions.None));

                if (null != texts && 0 < texts.Length)
                {
                    sourceList.Add(texts);
                }
            }

            if (GroupECheckBox.Checked)
            {
                texts = this.RemoveBlankAndNewLineData(GroupETextBox.Text.Split(this.sp, StringSplitOptions.None));

                if (null != texts && 0 < texts.Length)
                {
                    sourceList.Add(texts);
                }
            }

            if (GroupFCheckBox.Checked)
            {
                texts = this.RemoveBlankAndNewLineData(GroupFTextBox.Text.Split(this.sp, StringSplitOptions.None));

                if (null != texts && 0 < texts.Length)
                {
                    sourceList.Add(texts);
                }
            }

            if (GroupGCheckBox.Checked)
            {
                texts = this.RemoveBlankAndNewLineData(GroupGTextBox.Text.Split(this.sp, StringSplitOptions.None));

                if (null != texts && 0 < texts.Length)
                {
                    sourceList.Add(texts);
                }
            }

            if (!ListOverlappingCheckBox.Checked)
            {
                sourceList = DeduplicationList(sourceList);
            }

            List<string> resultList = this.Combination(sourceList);

            CNumberLabel.Text = COMBINATION_SYMBOL + string.Format(COMMA_NUMBER_FORMAT, resultList.Count);

            if (NumberingCheckBox.Checked)
            {
                resultList = this.AddNumbering(resultList);
            }

            string temp = string.Empty;
            int cLen = CSTextBox.Text.Length;
            int cnt = resultList.Count;
            int len = 0;

            List<int> indexList = new List<int>();

            if (0 < cnt)
            {
                for (int i = 0; i < cnt; i++)
                {
                    indexList.AddRange(GetTextIndex(resultList[i], len));

                    temp += resultList[i] + System.Environment.NewLine;

                    len = temp.Length - (cLen + i);

                    if (1 < cLen)
                    {
                        len += (cLen - 1);
                    }
                }
            }

            CombinationRichTextBox.Text = temp;

            foreach (int pos in indexList)
            {
                CombinationRichTextBox.Select(pos, cLen);
                CombinationRichTextBox.SelectionColor = Color.Red;
            }
        }

        /// <summary>
        /// ソースリストの重複排除を行い、返却する
        /// </summary>
        /// <param name="sourceList">ソースリスト</param>
        /// <returns>重複排除ソースリスト</returns>
        private List<string[]> DeduplicationList(List<string[]> sourceList)
        {
            List<string[]> resultList = new List<string[]>();
            Dictionary<string, bool> itemDictionary = new Dictionary<string, bool>();

            int cnt = sourceList.Count;

            if (1 >= cnt)
            {
                return sourceList;
            }

            resultList.Add(sourceList[0]);

            string[] texts = sourceList[0];

            foreach (string text in texts)
            {
                itemDictionary.Add(text, true);
            }

            for (int i = 1; i < cnt; i++)
            {
                List<string> newTexts = new List<string>();
                texts = sourceList[i];

                foreach (string text in texts)
                {
                    if (!itemDictionary.ContainsKey(text))
                    {
                        newTexts.Add(text);
                        itemDictionary.Add(text, true);
                    }
                }

                resultList.Add(newTexts.ToArray());
            }

            return resultList;
        }

        /// <summary>
        /// ナンバリング追加処理
        /// </summary>
        /// <param name="textList">組合わせリスト</param>
        /// <returns>ナンバリング追加後組合わせリスト</returns>
        private List<string> AddNumbering(List<string> textList)
        {
            List<string> resultList = new List<string>();

            string temp = null;
            int cnt = textList.Count;
            int digit = (cnt == 0) ? 1 : ((int)Math.Log10(cnt) + 1);
            int num = 1;

            foreach (string text in textList)
            {
                temp = string.Format("{0, " + digit.ToString() + "}", num) + " " + text;

                resultList.Add(temp);

                num++;
            }

            return resultList;
        }

        /// <summary>
        /// 組合わせ区切り位置を返す
        /// </summary>
        /// <param name="text">組合わせテキスト</param>
        /// <param name="add">加算位置</param>
        /// <returns>組合わせ区切り位置配列</returns>
        private int[] GetTextIndex(string text, int add = 0)
        {
            List<int> resultList = new List<int>();

            string[] datas = text.Split(new string[] { CSTextBox.Text }, StringSplitOptions.None);

            int len = add;
            int cLen = CSTextBox.Text.Length;
            int cnt = datas.Length;

            if (0 < cnt)
            {
                len += datas[0].Length;

                resultList.Add(len);

                cnt--;

                for (int i = 1; i < cnt; i++)
                {
                    len += datas[i].Length + cLen;

                    resultList.Add(len);
                }
            }

            return resultList.ToArray();
        }

        /// <summary>
        /// 空白、改行コードを削除して返す
        /// </summary>
        /// <param name="datas">文字列配列</param>
        /// <returns>空白、改行コードを削除した文字列配列</returns>
        private string[] RemoveBlankAndNewLineData(string[] datas)
        {
            List<string> resultList = new List<string>();

            foreach (string data in datas)
            {
                if (string.Empty != data)
                {
                    string temp = data.Replace(NEW_LINE_R, string.Empty).Replace(NEW_LINE_N, string.Empty);

                    resultList.Add(temp);
                }
            }

            return resultList.ToArray();
        }

        /// <summary>
        /// 組合わせ処理
        /// </summary>
        /// <param name="sourceList">組合わせ元リスト</param>
        /// <returns>組合わせリスト</returns>
        private List<string> Combination(List<string[]> sourceList)
        {
            List<string> resultList = new List<string>();

            if (null != sourceList && 0 < sourceList.Count)
            {
                List<string[]> resultData = Combinations<string>.GetCombinations(sourceList);

                foreach (string[] data in resultData)
                {
                    resultList.Add(string.Join(CSTextBox.Text, data));
                }
            }

            return resultList;
        }

        /// <summary>
        /// バージョンを返す
        /// </summary>
        /// <returns>バージョン</returns>
        public static Version GetVersion()
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();

            return asm.GetName().Version;
        }
    }

    /// <summary>
    /// 組合わせ
    /// </summary>
    /// <typeparam name="T">型</typeparam>
    public static class Combinations<T>
    {
        /// <summary>
        /// 組合わせを返す
        /// </summary>
        /// <param name="sourceList">組合わせ元リスト</param>
        /// <returns>組合わせリスト</returns>
        public static List<T[]> GetCombinations(List<T[]> sourceList)
        {
            List<T[]> resultList = new List<T[]>();
            Stack<T> stack = new Stack<T>();

            GetCombinationsCore(stack, resultList, sourceList);

            return resultList;
        }

        /// <summary>
        /// 再帰的に組合わせを求める
        /// </summary>
        /// <param name="stack">スタック</param>
        /// <param name="resultList">組合わせ結果リスト</param>
        /// <param name="sourceList">組合わせ元リスト</param>
        private static void GetCombinationsCore(Stack<T> stack, List<T[]> resultList, List<T[]> sourceList)
        {
            int dimension = stack.Count;

            if (sourceList.Count <= dimension)
            {
                T[] array = stack.ToArray();
                Array.Reverse(array);
                resultList.Add(array);

                return;
            }
            else
            {
                foreach (T item in sourceList[dimension])
                {
                    stack.Push(item);
                    GetCombinationsCore(stack, resultList, sourceList);
                    stack.Pop();
                }
            }
        }
    }
}
