module.exports = {
    plugins: [
        require('tailwindcss'),
        require('autoprefixer')({
            content: [
                './**/*.aspx',
            ],
            defaultExtractor: content => content.match(/[A-Za-z0-9-_:/]+/g) || []
        })
    ]
}