//
// File generated by HDevelop for HALCON/.NET (C#) Version 18.11.0.1
// Non-ASCII strings in this file are encoded in UTF-8.
// 
// Please note that non-ASCII characters in string constants are exported
// as octal codes in order to guarantee that the strings are correctly
// created on all systems, independent on any compiler settings.
// 
// Source files with different encoding should not be mixed in one project.
//

using HalconDotNet;

public partial class HDevelopExport
{
#if !(NO_EXPORT_MAIN || NO_EXPORT_APP_MAIN)
  public HDevelopExport()
  {
    // Default settings used in HDevelop
    HOperatorSet.SetSystem("width", 512);
    HOperatorSet.SetSystem("height", 512);
    if (HalconAPI.isWindows)
      HOperatorSet.SetSystem("use_window_thread","true");
    action();
  }
#endif

  // Procedures 
  // Chapter: Graphics / Text
  // Short Description: This procedure writes a text message. 
  public void disp_message (HTuple hv_WindowHandle, HTuple hv_String, HTuple hv_CoordSystem, 
      HTuple hv_Row, HTuple hv_Column, HTuple hv_Color, HTuple hv_Box)
  {



    // Local iconic variables 

    // Local control variables 

    HTuple hv_GenParamName = new HTuple(), hv_GenParamValue = new HTuple();
    HTuple   hv_Color_COPY_INP_TMP = new HTuple(hv_Color);
    HTuple   hv_Column_COPY_INP_TMP = new HTuple(hv_Column);
    HTuple   hv_CoordSystem_COPY_INP_TMP = new HTuple(hv_CoordSystem);
    HTuple   hv_Row_COPY_INP_TMP = new HTuple(hv_Row);

    // Initialize local and output iconic variables 
    //This procedure displays text in a graphics window.
    //
    //Input parameters:
    //WindowHandle: The WindowHandle of the graphics window, where
    //   the message should be displayed
    //String: A tuple of strings containing the text message to be displayed
    //CoordSystem: If set to 'window', the text position is given
    //   with respect to the window coordinate system.
    //   If set to 'image', image coordinates are used.
    //   (This may be useful in zoomed images.)
    //Row: The row coordinate of the desired text position
    //   A tuple of values is allowed to display text at different
    //   positions.
    //Column: The column coordinate of the desired text position
    //   A tuple of values is allowed to display text at different
    //   positions.
    //Color: defines the color of the text as string.
    //   If set to [], '' or 'auto' the currently set color is used.
    //   If a tuple of strings is passed, the colors are used cyclically...
    //   - if |Row| == |Column| == 1: for each new textline
    //   = else for each text position.
    //Box: If Box[0] is set to 'true', the text is written within an orange box.
    //     If set to' false', no box is displayed.
    //     If set to a color string (e.g. 'white', '#FF00CC', etc.),
    //       the text is written in a box of that color.
    //     An optional second value for Box (Box[1]) controls if a shadow is displayed:
    //       'true' -> display a shadow in a default color
    //       'false' -> display no shadow
    //       otherwise -> use given string as color string for the shadow color
    //
    //It is possible to display multiple text strings in a single call.
    //In this case, some restrictions apply:
    //- Multiple text positions can be defined by specifying a tuple
    //  with multiple Row and/or Column coordinates, i.e.:
    //  - |Row| == n, |Column| == n
    //  - |Row| == n, |Column| == 1
    //  - |Row| == 1, |Column| == n
    //- If |Row| == |Column| == 1,
    //  each element of String is display in a new textline.
    //- If multiple positions or specified, the number of Strings
    //  must match the number of positions, i.e.:
    //  - Either |String| == n (each string is displayed at the
    //                          corresponding position),
    //  - or     |String| == 1 (The string is displayed n times).
    //
    //
    //Convert the parameters for disp_text.
    if ((int)((new HTuple(hv_Row_COPY_INP_TMP.TupleEqual(new HTuple()))).TupleOr(
        new HTuple(hv_Column_COPY_INP_TMP.TupleEqual(new HTuple())))) != 0)
    {

      hv_Color_COPY_INP_TMP.Dispose();
      hv_Column_COPY_INP_TMP.Dispose();
      hv_CoordSystem_COPY_INP_TMP.Dispose();
      hv_Row_COPY_INP_TMP.Dispose();
      hv_GenParamName.Dispose();
      hv_GenParamValue.Dispose();

      return;
    }
    if ((int)(new HTuple(hv_Row_COPY_INP_TMP.TupleEqual(-1))) != 0)
    {
      hv_Row_COPY_INP_TMP.Dispose();
      hv_Row_COPY_INP_TMP = 12;
    }
    if ((int)(new HTuple(hv_Column_COPY_INP_TMP.TupleEqual(-1))) != 0)
    {
      hv_Column_COPY_INP_TMP.Dispose();
      hv_Column_COPY_INP_TMP = 12;
    }
    //
    //Convert the parameter Box to generic parameters.
    hv_GenParamName.Dispose();
    hv_GenParamName = new HTuple();
    hv_GenParamValue.Dispose();
    hv_GenParamValue = new HTuple();
    if ((int)(new HTuple((new HTuple(hv_Box.TupleLength())).TupleGreater(0))) != 0)
    {
      if ((int)(new HTuple(((hv_Box.TupleSelect(0))).TupleEqual("false"))) != 0)
      {
        //Display no box
        using (HDevDisposeHelper dh = new HDevDisposeHelper())
        {
        {
        HTuple 
          ExpTmpLocalVar_GenParamName = hv_GenParamName.TupleConcat(
            "box");
        hv_GenParamName.Dispose();
        hv_GenParamName = ExpTmpLocalVar_GenParamName;
        }
        }
        using (HDevDisposeHelper dh = new HDevDisposeHelper())
        {
        {
        HTuple 
          ExpTmpLocalVar_GenParamValue = hv_GenParamValue.TupleConcat(
            "false");
        hv_GenParamValue.Dispose();
        hv_GenParamValue = ExpTmpLocalVar_GenParamValue;
        }
        }
      }
      else if ((int)(new HTuple(((hv_Box.TupleSelect(0))).TupleNotEqual("true"))) != 0)
      {
        //Set a color other than the default.
        using (HDevDisposeHelper dh = new HDevDisposeHelper())
        {
        {
        HTuple 
          ExpTmpLocalVar_GenParamName = hv_GenParamName.TupleConcat(
            "box_color");
        hv_GenParamName.Dispose();
        hv_GenParamName = ExpTmpLocalVar_GenParamName;
        }
        }
        using (HDevDisposeHelper dh = new HDevDisposeHelper())
        {
        {
        HTuple 
          ExpTmpLocalVar_GenParamValue = hv_GenParamValue.TupleConcat(
            hv_Box.TupleSelect(0));
        hv_GenParamValue.Dispose();
        hv_GenParamValue = ExpTmpLocalVar_GenParamValue;
        }
        }
      }
    }
    if ((int)(new HTuple((new HTuple(hv_Box.TupleLength())).TupleGreater(1))) != 0)
    {
      if ((int)(new HTuple(((hv_Box.TupleSelect(1))).TupleEqual("false"))) != 0)
      {
        //Display no shadow.
        using (HDevDisposeHelper dh = new HDevDisposeHelper())
        {
        {
        HTuple 
          ExpTmpLocalVar_GenParamName = hv_GenParamName.TupleConcat(
            "shadow");
        hv_GenParamName.Dispose();
        hv_GenParamName = ExpTmpLocalVar_GenParamName;
        }
        }
        using (HDevDisposeHelper dh = new HDevDisposeHelper())
        {
        {
        HTuple 
          ExpTmpLocalVar_GenParamValue = hv_GenParamValue.TupleConcat(
            "false");
        hv_GenParamValue.Dispose();
        hv_GenParamValue = ExpTmpLocalVar_GenParamValue;
        }
        }
      }
      else if ((int)(new HTuple(((hv_Box.TupleSelect(1))).TupleNotEqual("true"))) != 0)
      {
        //Set a shadow color other than the default.
        using (HDevDisposeHelper dh = new HDevDisposeHelper())
        {
        {
        HTuple 
          ExpTmpLocalVar_GenParamName = hv_GenParamName.TupleConcat(
            "shadow_color");
        hv_GenParamName.Dispose();
        hv_GenParamName = ExpTmpLocalVar_GenParamName;
        }
        }
        using (HDevDisposeHelper dh = new HDevDisposeHelper())
        {
        {
        HTuple 
          ExpTmpLocalVar_GenParamValue = hv_GenParamValue.TupleConcat(
            hv_Box.TupleSelect(1));
        hv_GenParamValue.Dispose();
        hv_GenParamValue = ExpTmpLocalVar_GenParamValue;
        }
        }
      }
    }
    //Restore default CoordSystem behavior.
    if ((int)(new HTuple(hv_CoordSystem_COPY_INP_TMP.TupleNotEqual("window"))) != 0)
    {
      hv_CoordSystem_COPY_INP_TMP.Dispose();
      hv_CoordSystem_COPY_INP_TMP = "image";
    }
    //
    if ((int)(new HTuple(hv_Color_COPY_INP_TMP.TupleEqual(""))) != 0)
    {
      //disp_text does not accept an empty string for Color.
      hv_Color_COPY_INP_TMP.Dispose();
      hv_Color_COPY_INP_TMP = new HTuple();
    }
    //
    HOperatorSet.DispText(hv_WindowHandle, hv_String, hv_CoordSystem_COPY_INP_TMP, 
        hv_Row_COPY_INP_TMP, hv_Column_COPY_INP_TMP, hv_Color_COPY_INP_TMP, hv_GenParamName, 
        hv_GenParamValue);

    hv_Color_COPY_INP_TMP.Dispose();
    hv_Column_COPY_INP_TMP.Dispose();
    hv_CoordSystem_COPY_INP_TMP.Dispose();
    hv_Row_COPY_INP_TMP.Dispose();
    hv_GenParamName.Dispose();
    hv_GenParamValue.Dispose();

    return;
  }

#if !NO_EXPORT_MAIN
  // Main procedure 
  private void action()
  {


    // Stack for temporary objects 
    HObject[] OTemp = new HObject[20];

    // Local iconic variables 

    HObject ho_GaussFilter1, ho_GaussFilter2, ho_Filter;
    HObject ho_Image=null, ho_ImageFFT=null, ho_ImageConvol=null;
    HObject ho_ImageFiltered=null, ho_ImageResult=null, ho_RegionDynThresh=null;
    HObject ho_ConnectedRegions=null, ho_SelectedRegions=null;
    HObject ho_RegionDilation=null, ho_RegionUnion=null, ho_RegionClosing=null;
    HObject ho_ConnectedRegions1=null, ho_SelectedRegions1=null;

    // Local control variables 

    HTuple hv_AcqHandle = new HTuple(), hv_Height = new HTuple();
    HTuple hv_Width = new HTuple(), hv_WindowHandle = new HTuple();
    HTuple hv_Sigma1 = new HTuple(), hv_Sigma2 = new HTuple();
    HTuple hv_Min = new HTuple(), hv_Max = new HTuple(), hv_Range = new HTuple();
    HTuple hv_Area = new HTuple(), hv_Row = new HTuple(), hv_Column = new HTuple();
    HTuple hv_Number = new HTuple(), hv_ResultMessage = new HTuple();
    HTuple hv_Color = new HTuple();
    // Initialize local and output iconic variables 
    HOperatorSet.GenEmptyObj(out ho_GaussFilter1);
    HOperatorSet.GenEmptyObj(out ho_GaussFilter2);
    HOperatorSet.GenEmptyObj(out ho_Filter);
    HOperatorSet.GenEmptyObj(out ho_Image);
    HOperatorSet.GenEmptyObj(out ho_ImageFFT);
    HOperatorSet.GenEmptyObj(out ho_ImageConvol);
    HOperatorSet.GenEmptyObj(out ho_ImageFiltered);
    HOperatorSet.GenEmptyObj(out ho_ImageResult);
    HOperatorSet.GenEmptyObj(out ho_RegionDynThresh);
    HOperatorSet.GenEmptyObj(out ho_ConnectedRegions);
    HOperatorSet.GenEmptyObj(out ho_SelectedRegions);
    HOperatorSet.GenEmptyObj(out ho_RegionDilation);
    HOperatorSet.GenEmptyObj(out ho_RegionUnion);
    HOperatorSet.GenEmptyObj(out ho_RegionClosing);
    HOperatorSet.GenEmptyObj(out ho_ConnectedRegions1);
    HOperatorSet.GenEmptyObj(out ho_SelectedRegions1);
    //open_framegrabber ('MVision', 1, 1, 0, 0, 0, 0, 'progressive', 8, 'default', -1, 'false', 'auto', 'GEV:DA5684215 MV-CH100-60GM', 0, -1, AcqHandle)
    hv_AcqHandle.Dispose();
    HOperatorSet.OpenFramegrabber("DirectShow", 1, 1, 0, 0, 0, 0, "default", 8, "rgb", 
        -1, "false", "default", "[0] ", 0, -1, out hv_AcqHandle);
    HOperatorSet.GrabImageStart(hv_AcqHandle, -1);

    hv_Height.Dispose();
    HOperatorSet.GetFramegrabberParam(hv_AcqHandle, "image_height", out hv_Height);
    hv_Width.Dispose();
    HOperatorSet.GetFramegrabberParam(hv_AcqHandle, "image_width", out hv_Width);

    //创建显示窗口
    HOperatorSet.SetWindowAttr("background_color","black");
    HOperatorSet.OpenWindow(0,0,640,512,0,"visible","",out hv_WindowHandle);
    HDevWindowStack.Push(hv_WindowHandle);

    //优化傅里叶变换速度（对固定尺寸图像只需执行一次）
    //optimize_rft_speed (Width, Height, 'standard')
    //定义高斯滤波器参数（核心调参部分）
    //调参建议：Sigma1控制背景抑制强度，增大可过滤更大背景结构
    //  - 典型范围：5-20，表面纹理复杂时增大，光滑表面减小
    //  - 缺陷尺寸大于1cm建议>15，微小缺陷用5-10
    hv_Sigma1.Dispose();
    hv_Sigma1 = 5;
    //调参建议：Sigma2控制缺陷增强程度，减小可突出更细小缺陷
    //  - 典型范围：1-5，噪声较多时适当增大，灵敏度要求高则减小
    //  - 与Sigma1差值建议保持3倍以上确保带通效果
    hv_Sigma2.Dispose();
    hv_Sigma2 = 1;
    //生成低频高斯滤波器（创建背景模型）
    ho_GaussFilter1.Dispose();
    HOperatorSet.GenGaussFilter(out ho_GaussFilter1, hv_Sigma1, hv_Sigma1, 0.0, "none", 
        "rft", hv_Width, hv_Height);
    //生成高频高斯滤波器（创建缺陷模型）
    ho_GaussFilter2.Dispose();
    HOperatorSet.GenGaussFilter(out ho_GaussFilter2, hv_Sigma2, hv_Sigma2, 0.0, "none", 
        "rft", hv_Width, hv_Height);
    //组合带通滤波器（通过频域相减突出中间频率）
    ho_Filter.Dispose();
    HOperatorSet.SubImage(ho_GaussFilter1, ho_GaussFilter2, out ho_Filter, 1, 0);

    while ((int)(1) != 0)
    {
      ho_Image.Dispose();
      HOperatorSet.GrabImageAsync(out ho_Image, hv_AcqHandle, -1);

      //转换为灰度图像（如果是多通道需先转换）
      {
      HObject ExpTmpOutVar_0;
      HOperatorSet.Rgb1ToGray(ho_Image, out ExpTmpOutVar_0);
      ho_Image.Dispose();
      ho_Image = ExpTmpOutVar_0;
      }

      //执行正向傅里叶变换（频域处理核心步骤）
      ho_ImageFFT.Dispose();
      HOperatorSet.RftGeneric(ho_Image, out ho_ImageFFT, "to_freq", "none", "complex", 
          hv_Width);
      //频域卷积（滤波器应用关键步骤）
      ho_ImageConvol.Dispose();
      HOperatorSet.ConvolFft(ho_ImageFFT, ho_Filter, out ho_ImageConvol);
      //逆向傅里叶变换（转回空间域进行后续分析）
      ho_ImageFiltered.Dispose();
      HOperatorSet.RftGeneric(ho_ImageConvol, out ho_ImageFiltered, "from_freq", 
          "n", "real", hv_Width);

      //局部灰度范围增强（增强缺陷对比度）
      //调参建议：10x10邻域大小，增大可平滑噪声但会降低小缺陷灵敏度
      //  - 邻域尺寸建议为最小缺陷尺寸的1/2，例如5mm缺陷用20x20
      //  - 噪声较多时可改为15x15，细节丰富场景用5x5
      ho_ImageResult.Dispose();
      HOperatorSet.GrayRangeRect(ho_ImageFiltered, out ho_ImageResult, 5, 5);

      //获取动态阈值范围（自适应关键步骤）
      hv_Min.Dispose();hv_Max.Dispose();hv_Range.Dispose();
      HOperatorSet.MinMaxGray(ho_ImageResult, ho_ImageResult, 0, out hv_Min, out hv_Max, 
          out hv_Range);
      //动态阈值分割（核心调参点）
      //调参建议：0.8为敏感度系数，范围[0.6-0.95]
      //  - 误检多时提高至0.85，漏检时降低至0.7
      //  - 5.55为最小阈值，防止低对比度失效，根据噪声水平调整
      //  - 高噪声图像建议提高到10-15
      using (HDevDisposeHelper dh = new HDevDisposeHelper())
      {
      ho_RegionDynThresh.Dispose();
      HOperatorSet.Threshold(ho_ImageResult, out ho_RegionDynThresh, (((new HTuple(5.55)).TupleConcat(
          hv_Max*0.5))).TupleMax(), 255);
      }
      //连通域分析（分割独立缺陷）
      ho_ConnectedRegions.Dispose();
      HOperatorSet.Connection(ho_RegionDynThresh, out ho_ConnectedRegions);
      //面积筛选（过滤噪声点）
      //调参建议：4为最小像素面积，根据成像分辨率调整
      //  - 计算公式：最小缺陷实际尺寸(mm)/(像素精度mm/像素)^2
      //  - 例如0.1mm/像素精度，1mm缺陷对应100像素，此处设为80
      ho_SelectedRegions.Dispose();
      HOperatorSet.SelectShape(ho_ConnectedRegions, out ho_SelectedRegions, "area", 
          "and", 1, 99999);
      //膨胀外环
      ho_RegionDilation.Dispose();
      HOperatorSet.DilationCircle(ho_SelectedRegions, out ho_RegionDilation, 5.5);
      //将相连的连上
      ho_RegionUnion.Dispose();
      HOperatorSet.Union1(ho_RegionDilation, out ho_RegionUnion);

      //闭运算处理（弥合细小断裂）
      //调参建议：10为结构元素半径，影响缺陷形状完整度
      //  - 应根据缺陷最小间隙设置，建议为缺陷宽度的1/2
      //  - 过度弥合会合并相邻缺陷，可减小至5-8
      ho_RegionClosing.Dispose();
      HOperatorSet.ClosingCircle(ho_RegionUnion, out ho_RegionClosing, 10);
      ho_ConnectedRegions1.Dispose();
      HOperatorSet.Connection(ho_RegionClosing, out ho_ConnectedRegions1);
      //最终面积筛选（确定真实缺陷）
      //调参建议：10为最终确认阈值，消除残余噪声
      //  - 应大于初始筛选阈值，建议2-3倍初始值
      //  - 可根据样本统计设置，如均值-3sigma
      ho_SelectedRegions1.Dispose();
      HOperatorSet.SelectShape(ho_ConnectedRegions1, out ho_SelectedRegions1, "area", 
          "and", 1, 99999);
      //面积中心
      hv_Area.Dispose();hv_Row.Dispose();hv_Column.Dispose();
      HOperatorSet.AreaCenter(ho_SelectedRegions1, out hv_Area, out hv_Row, out hv_Column);
      hv_Number.Dispose();
      using (HDevDisposeHelper dh = new HDevDisposeHelper())
      {
      hv_Number = new HTuple(hv_Area.TupleLength()
          );
      }
      hv_ResultMessage.Dispose();
      using (HDevDisposeHelper dh = new HDevDisposeHelper())
      {
      hv_ResultMessage = ("疑似缺陷 "+hv_Number)+"个";
      }
      hv_Color.Dispose();
      hv_Color = "black";

      if (HDevWindowStack.IsOpen())
      {
        HOperatorSet.DispObj(ho_Image, HDevWindowStack.GetActive());
      }
      if (HDevWindowStack.IsOpen())
      {
        HOperatorSet.DispObj(ho_SelectedRegions1, HDevWindowStack.GetActive());
      }
      //显示位置调参：12,12为文本位置，根据图像内容调整避免遮挡
      disp_message(hv_WindowHandle, hv_ResultMessage, "window", 12, 12, hv_Color, 
          "true");
      // stop(...); only in hdevelop
    }
    HOperatorSet.CloseFramegrabber(hv_AcqHandle);
    ho_GaussFilter1.Dispose();
    ho_GaussFilter2.Dispose();
    ho_Filter.Dispose();
    ho_Image.Dispose();
    ho_ImageFFT.Dispose();
    ho_ImageConvol.Dispose();
    ho_ImageFiltered.Dispose();
    ho_ImageResult.Dispose();
    ho_RegionDynThresh.Dispose();
    ho_ConnectedRegions.Dispose();
    ho_SelectedRegions.Dispose();
    ho_RegionDilation.Dispose();
    ho_RegionUnion.Dispose();
    ho_RegionClosing.Dispose();
    ho_ConnectedRegions1.Dispose();
    ho_SelectedRegions1.Dispose();

    hv_AcqHandle.Dispose();
    hv_Height.Dispose();
    hv_Width.Dispose();
    hv_WindowHandle.Dispose();
    hv_Sigma1.Dispose();
    hv_Sigma2.Dispose();
    hv_Min.Dispose();
    hv_Max.Dispose();
    hv_Range.Dispose();
    hv_Area.Dispose();
    hv_Row.Dispose();
    hv_Column.Dispose();
    hv_Number.Dispose();
    hv_ResultMessage.Dispose();
    hv_Color.Dispose();

  }

#endif


}
#if !(NO_EXPORT_MAIN || NO_EXPORT_APP_MAIN)
public class HDevelopExportApp
{
  static void Main(string[] args)
  {
    new HDevelopExport();
  }
}
#endif

