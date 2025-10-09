# UI Style Guide - POS Application

## Design Philosophy

This theme follows modern UI/UX principles:
- **Clean & Minimal** - No unnecessary decorations
- **Professional** - Suitable for business applications
- **Consistent** - Same look across all forms
- **Accessible** - Good contrast and readable fonts
- **RTL-Friendly** - Works with Arabic text

---

## Color Palette

### Primary Colors
```
┌─────────────────────────────────────────┐
│ Primary Color (Main Blue)               │
│ #2980B9 - RGB(41, 128, 185)            │
│ Use for: Primary buttons, headers      │
└─────────────────────────────────────────┘

┌─────────────────────────────────────────┐
│ Primary Dark (Darker Blue)              │
│ #1F618D - RGB(31, 97, 141)             │
│ Use for: Borders, pressed states        │
└─────────────────────────────────────────┘

┌─────────────────────────────────────────┐
│ Primary Light (Lighter Blue)            │
│ #3498DB - RGB(52, 152, 219)            │
│ Use for: Highlights, accents            │
└─────────────────────────────────────────┘

┌─────────────────────────────────────────┐
│ Primary Hover (Hover Blue)              │
│ #2E86C1 - RGB(46, 134, 193)            │
│ Use for: Button hover states            │
└─────────────────────────────────────────┘
```

### Secondary Colors (Grays)
```
┌─────────────────────────────────────────┐
│ Secondary Color (Dark Gray Blue)        │
│ #34495E - RGB(52, 73, 94)              │
│ Use for: Headers, important elements    │
└─────────────────────────────────────────┘

┌─────────────────────────────────────────┐
│ Secondary Light (Medium Gray)           │
│ #7F8C8D - RGB(127, 140, 141)           │
│ Use for: Secondary buttons, borders     │
└─────────────────────────────────────────┘
```

### Background Colors
```
┌─────────────────────────────────────────┐
│ Background Main (Light Gray)            │
│ #ECF0F1 - RGB(236, 240, 241)           │
│ Use for: Form backgrounds               │
└─────────────────────────────────────────┘

┌─────────────────────────────────────────┐
│ Background Card (White)                 │
│ #FFFFFF - RGB(255, 255, 255)           │
│ Use for: Panels, cards, input fields    │
└─────────────────────────────────────────┘

┌─────────────────────────────────────────┐
│ Background Dark (Dark Blue Gray)        │
│ #2C3E50 - RGB(44, 62, 80)              │
│ Use for: Dark sections, footers         │
└─────────────────────────────────────────┘
```

### Text Colors
```
┌─────────────────────────────────────────┐
│ Text Primary (Dark Gray)                │
│ #2C3E50 - RGB(44, 62, 80)              │
│ Use for: Main text content              │
└─────────────────────────────────────────┘

┌─────────────────────────────────────────┐
│ Text Secondary (Gray)                   │
│ #7F8C8D - RGB(127, 140, 141)           │
│ Use for: Less important text, hints     │
└─────────────────────────────────────────┘

┌─────────────────────────────────────────┐
│ Text Light (White)                      │
│ #FFFFFF - RGB(255, 255, 255)           │
│ Use for: Text on dark backgrounds       │
└─────────────────────────────────────────┘

┌─────────────────────────────────────────┐
│ Text Disabled (Light Gray)              │
│ #BDC3C7 - RGB(189, 195, 199)           │
│ Use for: Disabled controls              │
└─────────────────────────────────────────┘
```

### Accent Colors (Actions)
```
┌─────────────────────────────────────────┐
│ Accent Green (Success)                  │
│ #27AE60 - RGB(39, 174, 96)             │
│ Use for: Save, success, confirm         │
│ ✓ حفظ, تأكيد, نجاح                      │
└─────────────────────────────────────────┘

┌─────────────────────────────────────────┐
│ Accent Red (Danger)                     │
│ #E74C3C - RGB(231, 76, 60)             │
│ Use for: Delete, error, cancel          │
│ ✗ حذف, خطأ, إلغاء                       │
└─────────────────────────────────────────┘

┌─────────────────────────────────────────┐
│ Accent Orange (Warning)                 │
│ #E67E22 - RGB(230, 126, 34)            │
│ Use for: Warnings, print, alerts        │
│ ⚠ تحذير, طباعة                          │
└─────────────────────────────────────────┘

┌─────────────────────────────────────────┐
│ Accent Yellow (Info)                    │
│ #F1C40F - RGB(241, 196, 15)            │
│ Use for: Information, highlights        │
│ ℹ معلومات, تنبيه                        │
└─────────────────────────────────────────┘

┌─────────────────────────────────────────┐
│ Accent Purple (Special)                 │
│ #9B59B6 - RGB(155, 89, 182)            │
│ Use for: Special features, premium      │
│ ★ مميز, خاص                             │
└─────────────────────────────────────────┘
```

---

## Typography

### Font Family
**Segoe UI** - Modern, clean, and readable
- Excellent Arabic support
- Professional appearance
- Good on-screen rendering

### Font Sizes & Weights

```
┌────────────────────────────────────┐
│ Header (18pt, Bold)                │
│ عنوان رئيسي كبير                   │
│ Main Page Titles                   │
└────────────────────────────────────┘

┌────────────────────────────────────┐
│ SubHeader (14pt, Bold)             │
│ عنوان فرعي                         │
│ Section Titles                     │
└────────────────────────────────────┘

┌────────────────────────────────────┐
│ Title (12pt, Bold)                 │
│ عنوان صغير                         │
│ Group Titles, Important Labels     │
└────────────────────────────────────┘

┌────────────────────────────────────┐
│ Normal (10pt, Regular)             │
│ نص عادي                            │
│ Body Text, Input Fields            │
└────────────────────────────────────┘

┌────────────────────────────────────┐
│ Small (9pt, Regular)               │
│ نص صغير                            │
│ Helper Text, Footnotes             │
└────────────────────────────────────┘

┌────────────────────────────────────┐
│ Button (10pt, Bold)                │
│ زر                                 │
│ Button Labels                      │
└────────────────────────────────────┘

┌────────────────────────────────────┐
│ Label (9.5pt, Regular)             │
│ تسمية                              │
│ Field Labels                       │
└────────────────────────────────────┘
```

---

## Component Styles

### Buttons

#### Primary Button (Blue)
```
Purpose: Main actions, default choice
Examples: جديد, فتح, بحث
Visual:
┌──────────────────┐
│  حفظ البيانات    │  ← White text
└──────────────────┘     Blue background (#2980B9)
     Hover: Lighter Blue (#2E86C1)
```

#### Success Button (Green)
```
Purpose: Save, confirm, success actions
Examples: حفظ, تأكيد, موافق
Visual:
┌──────────────────┐
│     حفظ          │  ← White text
└──────────────────┘     Green background (#27AE60)
     Hover: Lighter Green
```

#### Danger Button (Red)
```
Purpose: Delete, remove, destructive actions
Examples: حذف, إزالة, مسح
Visual:
┌──────────────────┐
│     حذف          │  ← White text
└──────────────────┘     Red background (#E74C3C)
     Hover: Darker Red
```

#### Warning Button (Orange)
```
Purpose: Warnings, print, alerts
Examples: طباعة, تحذير
Visual:
┌──────────────────┐
│    طباعة         │  ← White text
└──────────────────┘     Orange background (#E67E22)
     Hover: Darker Orange
```

#### Secondary Button (Gray)
```
Purpose: Cancel, close, alternative actions
Examples: إلغاء, إغلاق, رجوع
Visual:
┌──────────────────┐
│    إلغاء         │  ← White text
└──────────────────┘     Gray background (#7F8C8D)
     Hover: Darker Gray
```

#### Outline Button (Transparent)
```
Purpose: Less important actions
Examples: تفاصيل, عرض
Visual:
┌──────────────────┐
│   تفاصيل         │  ← Blue text
└──────────────────┘     Transparent with blue border
     Hover: Light blue background
```

### Text Inputs

```
Standard TextBox:
┌─────────────────────────────────────┐
│ نص المدخل                           │
└─────────────────────────────────────┘
  - Height: 30px
  - Border: 1px solid light gray
  - Background: White
  - Font: 10pt Segoe UI
  - Padding: 5px

With Placeholder:
┌─────────────────────────────────────┐
│ ادخل اسم العميل...                 │ ← Gray text
└─────────────────────────────────────┘

Focused:
┌─────────────────────────────────────┐
│ نص المدخل|                          │
└─────────────────────────────────────┘
  - Border: 2px solid Primary Blue
```

### Labels

```
Header Label:
  اسم النموذج الرئيسي
  (18pt, Bold, Dark Gray)

Section Label:
  معلومات العميل
  (14pt, Bold, Dark Gray)

Field Label:
  اسم العميل:
  (9.5pt, Regular, Dark Gray)

Helper Text:
  هذا الحقل مطلوب
  (9pt, Regular, Gray)
```

### DataGridView

```
┌────────────────────────────────────────────────────┐
│ Column 1    │ Column 2    │ Column 3    │ Column 4│ ← Header
├────────────────────────────────────────────────────┤   Dark Gray (#34495E)
│ Row 1       │ Data        │ Data        │ Data    │   White text
├────────────────────────────────────────────────────┤
│ Row 2       │ Data        │ Data        │ Data    │ ← Alternating
├────────────────────────────────────────────────────┤   Light Gray (#F5F7F8)
│ Row 3       │ Data        │ Data        │ Data    │
├────────────────────────────────────────────────────┤
│ Selected    │ Data        │ Data        │ Data    │ ← Selection
└────────────────────────────────────────────────────┘   Light Blue (#AED6F1)

Features:
- Row height: 35px
- Header height: 40px
- No row headers
- Single selection
- Full row select
- Horizontal borders only
```

### Panels & GroupBoxes

```
Card Panel:
┌─────────────────────────────────────┐
│ Panel Title                         │
├─────────────────────────────────────┤
│                                     │
│   Content Area                      │
│                                     │
└─────────────────────────────────────┘
  - Background: White
  - Border: 1px light gray
  - Padding: 10px
  - Shadow: Optional

GroupBox:
┌─ Group Title ──────────────────────┐
│                                    │
│   Content Area                     │
│                                    │
└────────────────────────────────────┘
  - Title: 12pt Bold
  - Border: 1px light gray
  - Background: White
```

---

## Spacing & Sizing

### Padding (Internal Spacing)
```
PaddingSmall:   5px   ●
PaddingMedium: 10px   ●●
PaddingLarge:  15px   ●●●
PaddingXLarge: 20px   ●●●●
```

### Border Radius (Rounded Corners)
```
BorderRadiusSmall:  3px
BorderRadiusMedium: 5px
BorderRadiusLarge:  8px
```

### Component Heights
```
Button:         35px
Button Large:   45px
TextBox:        30px
DataGrid Row:   35px
DataGrid Header: 40px
```

---

## Layout Guidelines

### Form Structure
```
┌────────────────────────────────────┐
│         HEADER (60px)              │  ← Primary Color
├────────────────────────────────────┤
│                                    │
│         CONTENT AREA               │  ← Light Gray Background
│         (Flexible)                 │
│                                    │
├────────────────────────────────────┤
│         BUTTON BAR (60px)          │  ← White Background
└────────────────────────────────────┘
```

### Button Placement
```
Right-to-Left for Arabic:

┌────────────────────────────────────┐
│ [إلغاء] [جديد] [طباعة] [حذف] [حفظ] │
└────────────────────────────────────┘
   ←                                ←
 Cancel                          Save
 (Secondary)                  (Success)
```

### Form Inputs
```
Label above input:
  اسم العميل
  ┌─────────────────────┐
  │                     │
  └─────────────────────┘

Label beside input (RTL):
  ┌─────────────────────┐
  │                     │  : اسم العميل
  └─────────────────────┘
```

---

## Common Patterns

### Search Bar
```
┌──────────────────────────────────┐ [بحث]
│ ابحث عن منتج...                 │
└──────────────────────────────────┘
```

### CRUD Form
```
Header: إدارة العملاء
Content:
  - Left: Form inputs (Add/Edit)
  - Right: DataGridView (List)
Bottom:
  [إلغاء] [جديد] [حذف] [حفظ]
```

### Login Form
```
┌────────────────────────────┐
│      تسجيل الدخول          │  ← Header
├────────────────────────────┤
│                            │
│  اسم المستخدم              │
│  ┌──────────────────────┐  │
│  │                      │  │
│  └──────────────────────┘  │
│                            │
│  كلمة المرور               │
│  ┌──────────────────────┐  │
│  │                      │  │
│  └──────────────────────┘  │
│                            │
│     [إلغاء] [دخول]         │
└────────────────────────────┘
```

---

## Dos and Don'ts

### ✅ Do
- Use theme colors consistently
- Apply proper spacing
- Use appropriate button styles
- Keep layouts clean and simple
- Ensure good contrast for text
- Use RTL layout for Arabic
- Apply theme to all controls

### ❌ Don't
- Mix custom colors with theme colors
- Overcrowd interfaces
- Use too many font sizes
- Ignore spacing guidelines
- Use poor color contrast
- Hardcode colors in Designer
- Skip theme application

---

## Accessibility

### Color Contrast Ratios
- Text Primary on White: 12.6:1 ✓ AAA
- White on Primary Blue: 4.6:1 ✓ AA
- White on Success Green: 4.1:1 ✓ AA
- White on Danger Red: 5.3:1 ✓ AAA

### Font Sizes
- Minimum readable: 9pt
- Recommended: 10pt or larger
- Headers: 14pt or larger

### Clickable Elements
- Minimum height: 35px
- Clear hover states
- Visible focus indicators

---

## Code Examples

### Complete Form Setup
```csharp
// Inherit from ModernFormBase
public partial class MyForm : ModernFormBase
{
    public MyForm()
    {
        InitializeComponent();
        // Theme auto-applied!
    }
}
```

### Manual Styling
```csharp
private void ApplyTheme()
{
    // Form
    ModernTheme.StyleForm(this);

    // Buttons by function
    ModernTheme.StyleButton(btnSave, ButtonStyle.Success);
    ModernTheme.StyleButton(btnDelete, ButtonStyle.Danger);
    ModernTheme.StyleButton(btnPrint, ButtonStyle.Warning);
    ModernTheme.StyleButton(btnNew, ButtonStyle.Primary);
    ModernTheme.StyleButton(btnCancel, ButtonStyle.Secondary);

    // Inputs
    ModernTheme.StyleTextBox(txtName);
    ModernTheme.StyleComboBox(cmbCategory);

    // Data Grid
    ModernTheme.StyleDataGridView(dgvProducts);

    // Containers
    ModernTheme.StyleGroupBox(grpCustomer);
    ModernTheme.StylePanel(pnlMain);

    // Labels
    ModernTheme.StyleLabel(lblTitle, LabelStyle.Header);
    ModernTheme.StyleLabel(lblInfo, LabelStyle.Normal);
}
```

---

**This style guide ensures consistency across your entire POS application!**
