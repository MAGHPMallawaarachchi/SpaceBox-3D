/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ['./**/*.aspx'],
  theme: {
    extend: {},
  },
    plugins: [
        require('@tailwindcss/forms'),
        require('@tailwindcss/typography'),
    ],
}
